namespace MySite.Models;

// A line between the subtotal and the total on a quote, e.g. a discount (negative) or a fee.
public record QuoteLine(string Label, decimal Amount);

public abstract class Offering : Listing, IBookable
{
    public required Provider Provider { get; init; }
    public required decimal Price { get; init; }
    public required string Place { get; init; }
    public required string Rating { get; init; }
    public required string Reviews { get; init; }
    public required string Tag { get; init; }

    // The Plan tab this offering appears under: "Tours", "Stays" or "Rentals".
    public abstract string Kind { get; }
    public abstract string PriceUnit { get; }

    // Label for the quantity stepper on the quote card.
    public abstract string QuantityLabel { get; }
    public virtual int DefaultQuantity => 1;

    public decimal Subtotal(int quantity) => Price * quantity;

    public virtual decimal QuoteTotal(int quantity) => Subtotal(quantity);

    // Itemises the difference between Subtotal and QuoteTotal.
    public virtual IEnumerable<QuoteLine> QuoteAdjustments(int quantity) => [];

    protected static decimal Percent(decimal amount, decimal percent) =>
        Math.Round(amount * percent / 100m, 0, MidpointRounding.AwayFromZero);
}
