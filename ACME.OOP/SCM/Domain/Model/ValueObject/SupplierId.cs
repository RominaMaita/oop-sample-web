namespace ACME.OOP.SCM.Domain.Model.ValueObject;
/// <summary>
/// This class represents a supplier ID value Object.
/// <remarks> This class is immutable should be used to represent money values.</remarks>
/// </summary>
public record SupplierId
{
    public string Identifier { get; init; }

    public SupplierId(string identifier)
    {
        if(string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentException("Value cannot be null or whitespace.");
        Identifier = identifier;
    }
};