namespace MySite.Models;

public class Provider(string name)
{
    public string Name { get; } = name;

    // Back-references, filled in by CebuData's static constructor.
    public List<Offering> Offerings { get; } = [];

    public override string ToString() => Name;
}
