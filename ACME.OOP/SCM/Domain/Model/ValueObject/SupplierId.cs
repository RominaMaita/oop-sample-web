namespace ACME.OOP.SCM.Domain.Model.ValueObject;

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