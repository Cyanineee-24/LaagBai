namespace MySite.Models;

public record Fact(string Label, string Value);

public record Highlight(string Title, string Body);

public class Destination : Listing
{
    public required string Town { get; init; }
    public required string Category { get; init; }
    public required string Tags { get; init; }
    public required string Travel { get; init; }

    // Detail-page content, filled in by CebuData's static constructor.
    public string? Intro { get; set; }
    public string? SecondaryCategory { get; set; }
    public List<Fact> Facts { get; } = [];
    public List<Highlight> Highlights { get; } = [];

    // Back-references, filled in by CebuData's static constructor.
    public List<Tour> Tours { get; } = [];
    public List<Stay> Stays { get; } = [];
    public List<VehicleRental> Rentals { get; } = [];

    public IEnumerable<Offering> Offerings => Tours.Concat<Offering>(Stays).Concat(Rentals);

    public IEnumerable<Offering> OfferingsOfKind(string kind) => Offerings.Where(o => o.Kind == kind);

    public string HeroIntro => Intro ?? Summary;

    public IEnumerable<string> Categories =>
        SecondaryCategory is null ? [Category] : [Category, SecondaryCategory];

    public string Href => $"/destinations/{Slug}";

    public bool Matches(string query) =>
        $"{Name} {Town} {Tags} {Category}".Contains(query, StringComparison.OrdinalIgnoreCase);
}
