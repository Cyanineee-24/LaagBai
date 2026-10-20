namespace MySite.Models;

public record Destination(
    string Id,
    string Name,
    string Town,
    string Region,
    string Category,
    string Tags,
    string Travel,
    string Blurb,
    string Photo)
{
    // Kawasan has its own detail page; everything else opens a filtered Explore search.
    public string Href => Id == "kawasan"
        ? "/kawasan-falls"
        : $"/explore?q={Uri.EscapeDataString(Name)}";

    public bool Matches(string query) =>
        $"{Name} {Town} {Tags} {Category}".Contains(query, StringComparison.OrdinalIgnoreCase);
}

public record RegionInfo(string Name, string Hub, string Description);

public record Collection(string Title, string Tagline, string[] Ids, string MoreHref);

public record PlanTile(string Kicker, string Title, string Body, string From, string Classes, string Href);
