using CultureInfo = System.Globalization.CultureInfo;
using MySite.Models;

namespace MySite.Data;

public static class CebuData
{
    public static readonly string[] Categories = ["Beach", "Nature", "Heritage", "Adventure", "Food"];

    public static readonly string[] Tabs = ["Tours", "Stays", "Rentals"];

    public static readonly Dictionary<string, string> Badge = new()
    {
        ["Beach"] = "bg-[#dcf0f5] text-[#0b5566]",
        ["Nature"] = "bg-[#dff1ec] text-[#0b5a49]",
        ["Heritage"] = "bg-[#f3e8d4] text-[#7a5310]",
        ["Adventure"] = "bg-[#ffe3d8] text-[#9a3a1b]",
        ["Food"] = "bg-[#f6e0e8] text-[#8a2550]",
    };

    public static readonly Dictionary<string, string> Dot = new()
    {
        ["Beach"] = "bg-[#2aa3bd]",
        ["Nature"] = "bg-[#2f9b77]",
        ["Heritage"] = "bg-[#c2902f]",
        ["Adventure"] = "bg-[#f4845f]",
        ["Food"] = "bg-[#c4517d]",
    };

    public static readonly Destination[] Destinations =
    [
        new("kawasan", "Kawasan Falls", "Badian", "South Cebu", "Nature", "adventure canyoneering falls", "3 hrs from city", "Turquoise pools under a three-tier limestone falls, reached by trail or by canyon jump.", "Kawasan Falls basin"),
        new("moalboal", "Moalboal Sardine Run", "Moalboal", "South Cebu", "Beach", "snorkel dive turtles panagsama", "2.5 hrs from city", "Millions of sardines swirl a few metres off Panagsama Beach. Bring a mask; no boat needed.", "Sardine ball, Panagsama"),
        new("osmena", "Osmeña Peak", "Dalaguete", "South Cebu", "Nature", "hike summit sunrise", "3 hrs from city", "Cebu’s highest point at 1,013 m. A 30-minute climb to jagged hills and a sea view both ways.", "Osmeña Peak ridges"),
        new("canyon", "Badian Canyoneering", "Alegria to Badian", "South Cebu", "Adventure", "jump canyon kawasan", "3 hrs from city", "Four hours of cliff jumps, river swims and rope slides down the Matutinao canyon.", "Canyoneering jump"),
        new("sumilon", "Sumilon Island", "Oslob", "Islands", "Beach", "sandbar marine sanctuary", "3.5 hrs from city", "A shifting white sandbar inside the Philippines’ first marine sanctuary, est. 1974.", "Sumilon sandbar"),
        new("tumalog", "Tumalog Falls", "Oslob", "South Cebu", "Nature", "falls curtain", "3.5 hrs from city", "A curtain of water streaming over moss-covered rock into a shallow, swimmable pool.", "Tumalog Falls curtain"),
        new("simala", "Simala Shrine", "Sibonga", "South Cebu", "Heritage", "church castle pilgrimage", "1.5 hrs from city", "A castle-style Marian shrine on a hilltop, run by the Marian Monks of Eucharistic Adoration.", "Simala Shrine facade"),
        new("carcar", "Carcar Heritage Town", "Carcar City", "South Cebu", "Food", "chicharon lechon heritage houses", "1 hr from city", "Spanish-era ancestral houses, St. Catherine’s Church and the island’s best chicharon.", "Carcar rotunda and market"),
        new("magellan", "Magellan’s Cross", "Cebu City", "Metro Cebu", "Heritage", "1521 history plaza", "Downtown", "Planted by Ferdinand Magellan’s crew in 1521, housed in a kiosk beside the Basilica.", "Magellan’s Cross kiosk ceiling"),
        new("basilica", "Basilica del Santo Niño", "Cebu City", "Metro Cebu", "Heritage", "church sinulog", "Downtown", "The oldest Roman Catholic church in the country and the heart of the Sinulog festival.", "Basilica del Santo Niño"),
        new("leah", "Temple of Leah", "Busay", "Metro Cebu", "Heritage", "roman temple view", "30 min from city", "A Roman-style temple built as a monument to love, with views over the whole city.", "Temple of Leah columns"),
        new("sirao", "Sirao Flower Garden", "Busay", "Metro Cebu", "Nature", "celosia mountain garden", "45 min from city", "Terraced celosia beds in red and yellow on the cool hills above the city.", "Sirao celosia beds"),
        new("larsian", "Larsian BBQ", "Fuente Osmeña", "Metro Cebu", "Food", "barbecue puso street food", "Uptown", "Open-air grill stalls serving skewers and hanging rice (puso) until late at night.", "Larsian grill smoke"),
        new("sutukil", "SuTuKil Lapu-Lapu", "Mactan", "Islands", "Food", "seafood sugba tuwa kilaw", "40 min from city", "Pick your fish at the market; have it grilled (sugba), in soup (tuwa) or raw in vinegar (kilaw).", "SuTuKil seafood market"),
        new("malapascua", "Malapascua Island", "Daanbantayan", "North Cebu", "Adventure", "thresher shark dive island", "4.5 hrs + boat", "Dawn dives at Monad Shoal for thresher sharks, one of the few places to see them daily.", "Malapascua bangka"),
        new("bantayan", "Bantayan Island", "Santa Fe", "Islands", "Beach", "white sand quiet", "3.5 hrs + ferry", "Flat, sandy and slow. Rent a scooter and loop the island past dried-fish stalls.", "Bantayan beach"),
        new("camotes", "Camotes Islands", "San Francisco", "Islands", "Beach", "lake danao cave", "2 hrs by ferry", "Lake Danao, Timubo Cave and Santiago Bay, all within a one-day motorbike loop.", "Santiago Bay, Camotes"),
        new("sogod", "Sogod Bay Cliffs", "Sogod", "North Cebu", "Adventure", "cliff jump kayak", "2 hrs from city", "Quiet coves and limestone ledges for kayaking and cliff jumping north of the city.", "Sogod coastline"),
    ];

    public static readonly RegionInfo[] Regions =
    [
        new("Metro Cebu", "Cebu City · Mandaue", "Spanish-era plazas, uptown food streets and the mountain barangays of Busay."),
        new("South Cebu", "Moalboal · Badian · Oslob", "Waterfalls, canyons, the sardine run and the island’s highest peak."),
        new("North Cebu", "Sogod · Daanbantayan", "Quieter coast, cliff coves and the jump-off for Malapascua."),
        new("Islands", "Mactan · Bantayan · Camotes", "Ferry-hop to white sand, island lakes and seafood by the kilo."),
    ];

    public static readonly Dictionary<string, Offer[]> Offers = new()
    {
        ["Tours"] =
        [
            new("t1", "Badian Canyoneering Day Tour", "Alegria to Kawasan, Badian", "Matutinao Adventure Guides", "4.9", "612", "Most booked", "Pick-up from Moalboal, guide, helmet, life vest and lunch. Ends at Kawasan Falls.", 2500, "person", "Canyoneering group", NearKawasan: true, Fee: 45),
            new("t2", "Kawasan + Moalboal Sardine Combo", "Badian & Moalboal", "Panagsama Reef Tours", "4.8", "341", "Full day", "Morning canyoneering, afternoon snorkel with the sardine run and turtles.", 3400, "person", "Snorkelers, Moalboal", NearKawasan: true, Fee: 45),
            new("t3", "Easy Trail & Bamboo Raft", "Kawasan Falls, Badian", "Kawasan Rafters’ Association", "4.6", "208", "Family friendly", "Flat 20-minute walk to the falls, raft ride under the main cascade.", 950, "person", "Bamboo raft at falls", NearKawasan: true, Fee: 45),
            new("t4", "Old Cebu Heritage Walk", "Cebu City", "Parian Heritage Walks", "4.8", "189", "3 hours", "Magellan’s Cross, the Basilica, Fort San Pedro and the Yap-San Diego Ancestral House.", 1200, "person", "Fort San Pedro walls"),
            new("t5", "Sumilon Sandbar Island Hop", "Oslob", "Oslob Bangkero Cooperative", "4.7", "274", "Half day", "Bangka to Sumilon Island, snorkel the sanctuary, then lunch on the sandbar.", 1800, "person", "Bangka at Sumilon"),
            new("t6", "Osmeña Peak Sunrise Hike", "Mantalongon, Dalaguete", "Dalaguete Mountain Guides", "4.8", "156", "Early start", "2:30 AM pick-up from Moalboal, guided climb, coffee at the summit.", 1500, "person", "Sunrise over Osmeña Peak"),
        ],
        ["Stays"] =
        [
            new("s1", "Matutinao Riverside Cottage", "Badian", "Tabura Family Homestay", "4.7", "98", "Walk to falls", "Native-style room by the river trailhead. Fan, private bath, breakfast.", 1800, "night", "Riverside cottage", NearKawasan: true),
            new("s2", "Panagsama Beach Dive Lodge", "Moalboal", "Blue Corner Lodges", "4.6", "402", "Moalboal", "Air-con double steps from the sardine run. 25 minutes to Kawasan.", 2600, "night", "Dive lodge room", NearKawasan: true),
            new("s3", "Badian Bay Resort Villa", "Badian", "Badian Bay Resorts", "4.9", "230", "Splurge", "Sea-view villa with pool and spa. Transfer to Kawasan included.", 8900, "night", "Resort villa pool", NearKawasan: true),
            new("s4", "Parian Heritage Inn", "Cebu City", "Calle Colon Stays", "4.5", "311", "Downtown", "Restored 1900s house a 10-minute walk from the Basilica and Magellan’s Cross.", 2200, "night", "Heritage inn courtyard"),
            new("s5", "Bounty Beach Huts", "Malapascua Island", "Logon Beach Co.", "4.6", "187", "Dive base", "Nipa huts on Bounty Beach. Dive shops open at 4:30 AM for thresher sharks.", 1600, "night", "Beach huts, Malapascua"),
            new("s6", "Sugar Beach Cabanas", "Santa Fe, Bantayan", "Bantayan Shore Stays", "4.7", "144", "Sunset side", "Garden cabanas facing the west beach, scooters for rent at the gate.", 3100, "night", "Cabanas at sunset"),
        ],
        ["Rentals"] =
        [
            new("r1", "Scooter 125cc", "Moalboal pick-up", "Moalboal Moto Rentals", "4.7", "520", "Self-drive", "Helmet and full tank. Driver’s licence required.", 500, "day", "Scooter", NearKawasan: true),
            new("r2", "Van with Driver (up to 10)", "Cebu City or Mactan Airport", "Sugbo Transport", "4.8", "366", "From the city", "Door-to-door from the city or airport, fuel and tolls included.", 4500, "day", "Passenger van", NearKawasan: true),
            new("r3", "Aqua Shoes & Dry Bag Set", "Matutinao, Badian", "Kawasan Gear Stall", "4.5", "129", "Gear", "Grippy shoes in all sizes and a 10L dry bag for your phone.", 150, "day", "Aqua shoes and dry bag", NearKawasan: true),
            new("r4", "Sedan with Driver (up to 4)", "Cebu City", "Sugbo Transport", "4.8", "211", "Day trips", "Ten hours of driving anywhere in Metro Cebu or as far as Oslob.", 3200, "day", "Sedan"),
            new("r5", "Snorkel Mask & Fins", "Panagsama Beach, Moalboal", "Panagsama Reef Tours", "4.6", "88", "Gear", "Fitted mask, snorkel and fins for the sardine run and turtle point.", 200, "day", "Snorkel gear"),
            new("r6", "Private Bangka Charter (up to 8)", "Mactan or Bantayan", "Island Hopper Bangkas", "4.7", "173", "With crew", "Outrigger boat with captain and crew for a full day of island hopping.", 5500, "day", "Outrigger bangka"),
        ],
    };

    public static readonly PlanTile[] PlanTiles =
    [
        new("Guided Tours", "Go with a local", "Canyoneering, island hopping and heritage walks led by DOT-accredited guides.", "From ₱950 per person", "bg-teal text-white", "/plan?tab=Tours"),
        new("Places to Stay", "Sleep near the action", "Riverside cottages in Badian, dive lodges in Moalboal, city hotels near the Basilica.", "From ₱1,600 per night", "bg-white text-ink border border-sand", "/plan?tab=Stays"),
        new("Get Around", "Your own wheels", "Scooters, vans with drivers and Ceres bus tips for the south coast run.", "From ₱150 per day", "bg-blush text-ink", "/plan?tab=Rentals"),
    ];

    public static readonly Collection[] Collections =
    [
        new("Island Escapes", "Ferry-hop to sandbars, island lakes and slow white beaches.", ["bantayan", "camotes", "sumilon", "malapascua"], "/explore?cat=Beach"),
        new("Chasing Waterfalls", "Turquoise basins and mossy curtains in the southern hills.", ["kawasan", "tumalog", "canyon"], "/explore?q=falls"),
        new("Heritage Trail", "Five centuries of faith and trade, from the 1521 cross outward.", ["magellan", "basilica", "simala", "carcar", "leah"], "/explore?cat=Heritage"),
        new("Under the Sea", "Sardine balls, thresher sharks and a sanctuary reef.", ["moalboal", "malapascua", "sumilon"], "/explore?q=dive"),
        new("Eat Like a Local", "Grilled skewers, crackling chicharon and fish cooked three ways.", ["larsian", "sutukil", "carcar"], "/explore?cat=Food"),
    ];

    public static Destination Get(string id) => Destinations.First(d => d.Id == id);

    public static IEnumerable<Destination> Get(params string[] ids) => ids.Select(Get);

    public static string TabOf(Offer offer) => Offers.First(kv => kv.Value.Contains(offer)).Key;

    public static string Peso(int amount) => "₱" + amount.ToString("N0", CultureInfo.InvariantCulture);

    public static string RegionHref(string region) => $"/explore?region={Uri.EscapeDataString(region)}";
}
