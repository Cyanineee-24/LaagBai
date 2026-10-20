namespace MySite.Models;

public class VehicleRental : Offering
{
    public const int LongRentalDays = 3;
    public const decimal LongRentalDiscountPercent = 15;

    // Destinations this rental is a practical way to reach.
    public required List<Destination> Serves { get; init; }

    public override string Kind => "Rentals";
    public override string PriceUnit => "day";
    public override string QuantityLabel => "Days";

    public decimal LongRentalDiscount(int quantity) =>
        quantity >= LongRentalDays ? Percent(Subtotal(quantity), LongRentalDiscountPercent) : 0;

    public override decimal QuoteTotal(int quantity) => Subtotal(quantity) - LongRentalDiscount(quantity);

    public override IEnumerable<QuoteLine> QuoteAdjustments(int quantity)
    {
        var discount = LongRentalDiscount(quantity);
        if (discount > 0) yield return new($"{LongRentalDays}+ day discount ({LongRentalDiscountPercent}%)", -discount);
    }
}
