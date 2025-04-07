using ACME.OOP.Procurement.Domain.Model.Aggregates;
using ACME.OOP.Procurement.Domain.Model.ValueObjects;
using ACME.OOP.SCM.Domain.Model.Aggregates;
using ACME.OOP.SCM.Domain.Model.ValueObject;
using ACME.OOP.Share.Domain.Model.ValueObjects;

//create a new supplier
var supplierAddress = new Address("123 Main St", "100","New York", null, "6701", "USA");
var supplier = new Supplier("Microsoft, Inc.", supplierAddress);

//create a new purchase order

Console.WriteLine("Creating purchase order...");
var purchaseOrder = new PurchaseOrder("P0111", supplier.SupplierId, DateTime.Now, "USD");


purchaseOrder
    .AddItem(ProductId.New(), 10, 25.99m)
    .AddItem(ProductId.New(), 5, 15.99m);

Console.WriteLine($"Purchase order ID: {purchaseOrder.OrderNumber} created for supplier {supplier.Name}");

foreach(var item in purchaseOrder.Items)
    Console.WriteLine($"Item subtotal: {item.CalculateSubTotal().Amount}{item.CalculateSubTotal().Currency}");
    
    
//Calculate the total amount
Console.WriteLine($"Total: {purchaseOrder.CalculateTotal().Amount}{purchaseOrder.CalculateTotal().Currency}");
    
    
    