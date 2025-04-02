namespace ACME.OOP.Share.Domain.Model.ValueObjects;

public record Address
{
    public string Street { get; init; }
    public string Number { get; init; }
    public string City { get; init; }
    public string StateOrRegion { get; init; }
    public string PostalCode { get; init; }
    public string Country { get; init; }

    public Address(string street, string number, string city, string stateOrRegion, string postalCode, string country)
    {
        // Parameter Validation
        if (string.IsNullOrWhiteSpace(street))
        {
            throw new ArgumentException("Street address cannot be null or whitespace.", nameof(street));
        }

        if (string.IsNullOrWhiteSpace(number))
        {
            throw new ArgumentException("Number address cannot be null or whitespace.", nameof(number));
        }

        if (string.IsNullOrWhiteSpace(city))
        {
            throw new ArgumentException("City address cannot be null or whitespace.", nameof(city));
        }

        if (string.IsNullOrWhiteSpace(stateOrRegion))
        {
            throw new ArgumentException("State or Region address cannot be null or whitespace.", nameof(stateOrRegion));
        }

        if (string.IsNullOrWhiteSpace(postalCode))
        {
            throw new ArgumentException("PostalCode address cannot be null or whitespace.", nameof(postalCode));
        }

        if (string.IsNullOrWhiteSpace(country))
        {
            throw new ArgumentException("Country address cannot be null or whitespace.", nameof(country));
        }
        
        Street = street;
        Number = number;
        City = city;
        StateOrRegion = stateOrRegion;
        PostalCode = postalCode;
        Country = country;
        
    }

}