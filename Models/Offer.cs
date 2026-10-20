namespace MySite.Models;

public record Offer(
    string Id,
    string Name,
    string Place,
    string Provider,
    string Rating,
    string Reviews,
    string Tag,
    string Description,
    int Price,
    string Unit,
    string Photo,
    bool NearKawasan = false,
    int Fee = 0);
