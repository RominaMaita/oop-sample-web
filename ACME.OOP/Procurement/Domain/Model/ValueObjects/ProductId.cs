namespace ACME.OOP.Procurement.Domain.Model.ValueObjects;
/// <summary>
/// This class represents a product id value object.
/// </summary>
public record ProductId
{
    public Guid Id { get; init; }
    /// <summary>
    /// Constructs a new instance of the see cref="ProductId"/> class
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="ArgumentException"></exception>
    public ProductId(Guid id)
    {
        if(id == Guid.Empty)
            throw new ArgumentException("Product id cannot be empty.", nameof(id));
        Id = id;
    }
    
    public static ProductId New() => new(Guid.NewGuid());
};