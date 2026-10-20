namespace MySite.Models;

public class Tour : Offering
{
    public const int GroupSize = 4;
    public const decimal GroupDiscountPercent = 10;

    public required List<Destination> Stops { get; init; }

    // Per-person park fee collected on top of the tour price (e.g. ₱45 at Kawasan).
    public decimal EnvironmentalFee { get; init; }

    public override string Kind => "Tours";
    public override string PriceUnit => "person";
    public override string QuantityLabel => "Guests";
    public override int DefaultQuantity => 2;

    public decimal GroupDiscount(int quantity) =>
        quantity >= GroupSize ? Percent(Subtotal(quantity), GroupDiscountPercent) : 0;

    public decimal Fees(int quantity) => EnvironmentalFee * quantity;

    public override decimal QuoteTotal(int quantity) =>
        Subtotal(quantity) - GroupDiscount(quantity) + Fees(quantity);

    public override IEnumerable<QuoteLine> QuoteAdjustments(int quantity)
    {
        var discount = GroupDiscount(quantity);
        if (discount > 0) yield return new($"Group discount ({GroupDiscountPercent}%, {GroupSize}+ guests)", -discount);

        var fees = Fees(quantity);
        if (fees > 0) yield return new($"Environmental fee (₱{EnvironmentalFee:N0} × {quantity})", fees);
    }
}
