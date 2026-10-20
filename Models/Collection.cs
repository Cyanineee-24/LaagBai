namespace MySite.Models;

public class Collection
{
    public required string Title { get; init; }
    public required string Tagline { get; init; }
    public required List<Destination> Destinations { get; init; }
    public required string MoreHref { get; init; }
}
