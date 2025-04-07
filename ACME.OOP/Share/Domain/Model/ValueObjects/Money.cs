namespace ACME.OOP.Share.Domain.Model.ValueObjects;

/// <summary>
/// Represents a monetary value with aan amount and currency.
/// </summary>
/// <remarks>
/// This class is immutable and should be used to represent money values.
/// </remarks>


public record Money
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }

    /// <summary>
    /// Construct a new instance of the <see cref="Money"/> class. 
    /// </summary>
    /// <param name="amount"> The amount as a decimal value</param>
    /// <param name="currency"> The 3-letter code for currency </param>
    /// <exception cref="ArgumentException"> If currency is null, write space or not</exception>
    
    public Money(decimal amount, string currency)
    {
        if(string.IsNullOrWhiteSpace(currency) || currency.Length != 3)
            throw new ArgumentException("Currency address cannot be null or whitespace.", nameof(currency));
        Amount = amount;
        Currency = currency;
    }
};