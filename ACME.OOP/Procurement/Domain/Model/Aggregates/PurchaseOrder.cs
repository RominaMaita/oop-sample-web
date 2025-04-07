using ACME.OOP.Procurement.Domain.Model.ValueObjects;
using ACME.OOP.SCM.Domain.Model.ValueObject;
using ACME.OOP.Share.Domain.Model.ValueObjects;

namespace ACME.OOP.Procurement.Domain.Model.Aggregates;

public class PurchaseOrder(string orderNumber, SupplierId supplierId, DateTime orderDate, string currency)
{
    private readonly List<PurchaseOrderItem> _items = new();
    
    public string OrderNumber { get; } = orderNumber ?? throw new ArgumentNullException(nameof(orderNumber));
    public SupplierId Supplier { get;}= supplierId ?? throw new ArgumentNullException(nameof(supplierId));
    public DateTime OrderDate { get; } = orderDate;
    public string Currency { get; } = string.IsNullOrWhiteSpace(currency) || currency.Length != 3 
        ? throw new ArgumentException("Currency must be 3 or more characters.", nameof(currency)) : currency;
  
    public IReadOnlyList<PurchaseOrderItem> Items => _items.AsReadOnly();

    public PurchaseOrder AddItem(ProductId productId, int quantity, decimal unitPriceAmount)
    {
        ArgumentNullException.ThrowIfNull(productId);
        if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than zero.");
        
        if(unitPriceAmount <0) throw new ArgumentOutOfRangeException(nameof(unitPriceAmount), "UnitPriceAmount cannot be less than zero.");
        
        var unitPrice = new Money(unitPriceAmount, Currency);
        var item = new PurchaseOrderItem(productId, quantity, unitPrice);
        _items.Add(item);
        return this;
    }

    public Money CalculateTotal()
    {
        var total = _items.Sum(item => item.CalculateSubTotal().Amount);
        return new Money(total, Currency);
    }
}