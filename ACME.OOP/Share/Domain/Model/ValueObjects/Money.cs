namespace ACME.OOP.Share.Domain.Model.ValueObjects;

public record Money
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }

    public Money(decimal amount, string currency)
    {
        if(string.IsNullOrWhiteSpace(currency) || currency.Length != 3)
            throw new ArgumentException("Currency address cannot be null or whitespace.", nameof(currency));
        Amount = amount;
        Currency = currency;
    }
};