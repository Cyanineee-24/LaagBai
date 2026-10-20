using System.Text;

namespace MySite.Models;

// Anything the site lists with a name, photo and region: destinations and bookable offerings.
public abstract class Listing
{
    public required string Id { get; init; }
    public required string Name { get; init; }
    public required string Summary { get; init; }
    public required string Region { get; init; }

    // Null renders the captioned placeholder instead of a photo.
    public string? ImageUrl { get; init; }
    public required string PhotoCaption { get; init; }

    public string Slug => Slugify(Name);

    // "Osmeña Peak" → "osmena-peak", "Magellan’s Cross" → "magellans-cross".
    private static string Slugify(string text)
    {
        var sb = new StringBuilder();
        // FormD splits ñ into n + a combining tilde, which is then dropped with the apostrophes.
        foreach (var c in text.Normalize(NormalizationForm.FormD).ToLowerInvariant())
        {
            if (char.IsAsciiLetterOrDigit(c)) sb.Append(c);
            else if (c is ' ' or '-' && sb.Length > 0 && sb[^1] != '-') sb.Append('-');
        }
        return sb.ToString().Trim('-');
    }
}
