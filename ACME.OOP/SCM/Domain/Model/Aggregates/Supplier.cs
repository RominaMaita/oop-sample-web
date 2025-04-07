using ACME.OOP.SCM.Domain.Model.ValueObject;
using ACME.OOP.Share.Domain.Model.ValueObjects;

namespace ACME.OOP.SCM.Domain.Model.Aggregates;
/// <summary>
/// This class represents a supplier aggregate.
/// <remarks>
/// This class is the aggregate root
/// </remarks>
/// </summary>
public class Supplier
{
    public SupplierId SupplierId { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }

    public Supplier(string name, Address address)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Value cannot be null or whitespace.", nameof(name));
        SupplierId = new SupplierId(Guid.NewGuid().ToString());
        Name = name;
        Address = address ?? throw new ArgumentNullException(nameof(address));
        
    }
    
};