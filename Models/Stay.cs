namespace MySite.Models;

public class Stay : Offering
{
    public const decimal TaxPercent = 12;

    public required Destination NearestDestination { get; init; }

    public override string Kind => "Stays";
    public override string PriceUnit => "night";
    public override string QuantityLabel => "Nights";

    public decimal Tax(int quantity) => Percent(Subtotal(quantity), TaxPercent);

    public override decimal QuoteTotal(int quantity) => Subtotal(quantity) + Tax(quantity);

    public override IEnumerable<QuoteLine> QuoteAdjustments(int quantity)
    {
        yield return new($"Tax ({TaxPercent}%)", Tax(quantity));
    }
}
