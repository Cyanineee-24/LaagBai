using MySite.Models;

namespace MySite.Data;

// One quote per circuit, shared by the Kawasan Falls and Plan pages.
public class QuoteState
{
    public const int MinQty = 1;
    public const int MaxQty = 20;

    public string Tab { get; private set; } = "Tours";
    public Offer Selected { get; private set; } = CebuData.Offers["Tours"][0];
    public int Qty { get; private set; } = 2;

    public event Action? Changed;

    public int Subtotal => Selected.Price * Qty;
    public int Fee => Selected.Fee * Qty;
    public int Total => Subtotal + Fee;

    public string UnitPlural => Selected.Unit switch
    {
        "person" => "Guests",
        "night" => "Nights",
        _ => "Days",
    };

    public void SetTab(string tab)
    {
        if (!CebuData.Offers.TryGetValue(tab, out var offers)) return;
        Tab = tab;
        Selected = offers[0];
        Qty = tab == "Tours" ? 2 : 1;
        Changed?.Invoke();
    }

    public void Choose(Offer offer)
    {
        Selected = offer;
        Tab = CebuData.TabOf(offer);
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
