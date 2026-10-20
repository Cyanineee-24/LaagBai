namespace MySite.Models;

public interface IBookable
{
    decimal Price { get; }

    // What one unit of Price buys: "person", "night" or "day".
    string PriceUnit { get; }

    decimal QuoteTotal(int quantity);
}
