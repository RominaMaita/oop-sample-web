namespace ACME.OOP.Share.Domain.Model.ValueObjects;

public record Address
{
    public string Street { get; init; }
    public string Number { get; init; }
    public string City { get; init; }
    public string StateOrRegion { get; init; }
    public string PostalCode { get; init; }
    public string Country { get; init; }

    /// <summary>
    /// This class represents an address value object.
    /// </summary>
    /// <param name="street"></param>
    /// <param name="number"></param>
    /// <param name="city"></param>
    /// <param name="stateOrRegion"></param>
    /// <param name="postalCode"></param>
    /// <param name="country"></param>
    /// <exception cref="ArgumentException"></exception>
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