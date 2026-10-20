using MySite.Models;

namespace MySite.Data;

// One quote per circuit, shared by the Kawasan Falls and Plan pages.
public class QuoteState
{
    public const int MinQty = 1;
    public const int MaxQty = 20;

    public Offering Selected { get; private set; } = CebuData.Tours[0];
    public int Qty { get; private set; } = CebuData.Tours[0].DefaultQuantity;

    // The active tab always follows the selected offering.
    public string Tab => Selected.Kind;

    public event Action? Changed;

    public decimal Subtotal => Selected.Subtotal(Qty);
    public IEnumerable<QuoteLine> Adjustments => Selected.QuoteAdjustments(Qty);
    public decimal Total => Selected.QuoteTotal(Qty);

    // Selects the first offering of that kind — site-wide, or only those linked to `within`.
    public void SetTab(string kind, Destination? within = null)
    {
        var first = (within?.OfferingsOfKind(kind) ?? CebuData.OfferingsOf(kind)).FirstOrDefault();
        if (first is null) return;
        Selected = first;
        Qty = Selected.DefaultQuantity;
        Changed?.Invoke();
    }

    public void Choose(Offering offering)
    {
        Selected = offering;
        Changed?.Invoke();
    }

    public void Increment()
    {
        Qty = Math.Min(MaxQty, Qty + 1);
        Changed?.Invoke();
    }

    public void Decrement()
    {
        Qty = Math.Max(MinQty, Qty - 1);
        Changed?.Invoke();
    }
}
