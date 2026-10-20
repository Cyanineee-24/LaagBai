using CultureInfo = System.Globalization.CultureInfo;
using MySite.Models;

namespace MySite.Data;

public static class CebuData
{
    public static readonly string[] Categories = ["Beach", "Nature", "Heritage", "Adventure", "Food"];

    // Matches Offering.Kind.
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

    public static readonly RegionInfo[] Regions =
    [
        new("Metro Cebu", "Cebu City · Mandaue", "Spanish-era plazas, uptown food streets and the mountain barangays of Busay."),
        new("South Cebu", "Moalboal · Badian · Oslob", "Waterfalls, canyons, the sardine run and the island’s highest peak."),
        new("North Cebu", "Sogod · Daanbantayan", "Quieter coast, cliff coves and the jump-off for Malapascua."),
        new("Islands", "Mactan · Bantayan · Camotes", "Ferry-hop to white sand, island lakes and seafood by the kilo."),
    ];

    public static readonly PlanTile[] PlanTiles =
    [
        new("Guided Tours", "Go with a local", "Canyoneering, island hopping and heritage walks led by DOT-accredited guides.", "From ₱950 per person", "bg-teal text-white", "/plan?tab=Tours"),
        new("Places to Stay", "Sleep near the action", "Riverside cottages in Badian, dive lodges in Moalboal, city hotels near the Basilica.", "From ₱1,600 per night", "bg-white text-ink border border-sand", "/plan?tab=Stays"),
        new("Get Around", "Your own wheels", "Scooters, vans with drivers and Ceres bus tips for the south coast run.", "From ₱150 per day", "bg-blush text-ink", "/plan?tab=Rentals"),
    ];

    public static readonly Destination[] Destinations;
    public static readonly Tour[] Tours;
    public static readonly Stay[] Stays;
    public static readonly VehicleRental[] Rentals;
    public static readonly Offering[] Offerings;
    public static readonly Provider[] Providers;
    public static readonly Collection[] Collections;

    static CebuData()
    {
        Destinations =
        [
            Dest("kawasan", "Kawasan Falls", "Badian", "South Cebu", "Nature", "adventure canyoneering falls", "3 hrs from city", "Turquoise pools under a three-tier limestone falls, reached by trail or by canyon jump.", "Kawasan Falls basin", "kawasan_falls.jpg"),
            Dest("moalboal", "Moalboal Sardine Run", "Moalboal", "South Cebu", "Beach", "snorkel dive turtles panagsama", "2.5 hrs from city", "Millions of sardines swirl a few metres off Panagsama Beach. Bring a mask; no boat needed.", "Sardine ball, Panagsama", "sardines_ball.jpg"),
            Dest("osmena", "Osmeña Peak", "Dalaguete", "South Cebu", "Nature", "hike summit sunrise", "3 hrs from city", "Cebu’s highest point at 1,013 m. A 30-minute climb to jagged hills and a sea view both ways.", "Osmeña Peak ridges", "osmenapeak.jpg"),
            Dest("canyon", "Badian Canyoneering", "Alegria to Badian", "South Cebu", "Adventure", "jump canyon kawasan", "3 hrs from city", "Four hours of cliff jumps, river swims and rope slides down the Matutinao canyon.", "Canyoneering jump", "badian_canyonnering.jpg"),
            Dest("sumilon", "Sumilon Island", "Oslob", "Islands", "Beach", "sandbar marine sanctuary", "3.5 hrs from city", "A shifting white sandbar inside the Philippines’ first marine sanctuary, est. 1974.", "Sumilon sandbar", "sumilon_island.jpg"),
            Dest("tumalog", "Tumalog Falls", "Oslob", "South Cebu", "Nature", "falls curtain", "3.5 hrs from city", "A curtain of water streaming over moss-covered rock into a shallow, swimmable pool.", "Tumalog Falls curtain", "tumalog_falls.jpg"),
            Dest("simala", "Simala Shrine", "Sibonga", "South Cebu", "Heritage", "church castle pilgrimage", "1.5 hrs from city", "A castle-style Marian shrine on a hilltop, run by the Marian Monks of Eucharistic Adoration.", "Simala Shrine facade", "simala.jpg"),
            Dest("carcar", "Carcar Heritage Town", "Carcar City", "South Cebu", "Food", "chicharon lechon heritage houses", "1 hr from city", "Spanish-era ancestral houses, St. Catherine’s Church and the island’s best chicharon.", "Carcar rotunda and market", "carcar_rotunda.jpg"),
            Dest("magellan", "Magellan’s Cross", "Cebu City", "Metro Cebu", "Heritage", "1521 history plaza", "Downtown", "Planted by Ferdinand Magellan’s crew in 1521, housed in a kiosk beside the Basilica.", "Magellan’s Cross kiosk ceiling", "magellans_cross.jpg"),
            Dest("basilica", "Basilica del Santo Niño", "Cebu City", "Metro Cebu", "Heritage", "church sinulog", "Downtown", "The oldest Roman Catholic church in the country and the heart of the Sinulog festival.", "Basilica del Santo Niño", "basilica.jpg"),
            Dest("leah", "Temple of Leah", "Busay", "Metro Cebu", "Heritage", "roman temple view", "30 min from city", "A Roman-style temple built as a monument to love, with views over the whole city.", "Temple of Leah columns", "temple_of_leah.jpg"),
            Dest("sirao", "Sirao Flower Garden", "Busay", "Metro Cebu", "Nature", "celosia mountain garden", "45 min from city", "Terraced celosia beds in red and yellow on the cool hills above the city.", "Sirao celosia beds", "sirao_garden.jpg"),
            Dest("larsian", "Larsian BBQ", "Fuente Osmeña", "Metro Cebu", "Food", "barbecue puso street food", "Uptown", "Open-air grill stalls serving skewers and hanging rice (puso) until late at night.", "Larsian grill smoke", "larsian_grill_smoke.jpg"),
            Dest("sutukil", "SuTuKil Lapu-Lapu", "Mactan", "Islands", "Food", "seafood sugba tuwa kilaw", "40 min from city", "Pick your fish at the market; have it grilled (sugba), in soup (tuwa) or raw in vinegar (kilaw).", "SuTuKil seafood market", "sutukil_lapu_lapu.jpg"),
            Dest("malapascua", "Malapascua Island", "Daanbantayan", "North Cebu", "Adventure", "thresher shark dive island", "4.5 hrs + boat", "Dawn dives at Monad Shoal for thresher sharks, one of the few places to see them daily.", "Malapascua bangka", "malapascua_island.jpg"),
            Dest("bantayan", "Bantayan Island", "Santa Fe", "Islands", "Beach", "white sand quiet", "3.5 hrs + ferry", "Flat, sandy and slow. Rent a scooter and loop the island past dried-fish stalls.", "Bantayan beach", "bantayan_island.webp"),
            Dest("camotes", "Camotes Islands", "San Francisco", "Islands", "Beach", "lake danao cave", "2 hrs by ferry", "Lake Danao, Timubo Cave and Santiago Bay, all within a one-day motorbike loop.", "Santiago Bay, Camotes", "camotes_island.jpg"),
            Dest("sogod", "Sogod Bay Cliffs", "Sogod", "North Cebu", "Adventure", "cliff jump kayak", "2 hrs from city", "Quiet coves and limestone ledges for kayaking and cliff jumping north of the city.", "Sogod coastline", "sogod_bay.jpg"),
        ];

        Details("kawasan", "Matutinao, Badian", secondaryCategory: "Adventure",
            intro: "A three-tiered limestone falls in Matutinao, Badian, and the finish line of Cebu’s best-known canyoneering route.",
            facts: [new("Location", "Matutinao, Badian"), new("From Cebu City", "3 hrs by Ceres bus"), new("Entrance", "₱45 environmental fee"), new("Open", "6:00 AM – 5:00 PM"), new("Best months", "Dec – May")],
            highlights:
            [
                new("Three tiers of falls", "The main 40 m drop is the busiest. Climb past it to the quieter second and third basins."),
                new("Canyoneering finish", "Most canyon tours start upstream in Alegria and end here after jumps of up to 10 m."),
                new("Bamboo rafts", "Local operators pole you right under the cascade for a free shoulder massage."),
                new("Go early", "Tour groups arrive from 10 AM. Arrive at opening for clear water and empty pools."),
            ]);
        Details("moalboal", "Panagsama Beach, Moalboal",
            highlights:
            [
                new("The sardine run", "The shoal sits just past the reef drop-off, close enough to swim out from the beach."),
                new("Turtles in the shallows", "Sea turtles graze on the reef flats off Panagsama; keep your distance and don’t touch."),
                new("Pescador Island", "A small island offshore with a reef wall, reached by bangka for snorkelling and diving."),
            ]);
        Details("osmena", "Mantalongon, Dalaguete", extra: [new("Elevation", "1,013 m")],
            highlights:
            [
                new("Sunrise from the top", "Start before dawn to watch the sun come up over both coasts."),
                new("Jagged ridges", "The summit looks out over rows of sharp, grassy hills unlike anywhere else on the island."),
                new("Vegetable country", "Mantalongon’s cool upland farms supply much of Cebu’s highland produce."),
            ]);
        Details("canyon", "Alegria to Badian", secondaryCategory: "Nature", extra: [new("Duration", "About 4 hours")],
            highlights:
            [
                new("Cliff jumps", "Jumps along the canyon go up to 10 m, with lower ledges for anyone who would rather not."),
                new("River swims and slides", "Long stretches of swimming and natural rock slides between the jumps."),
                new("Ends at Kawasan", "The route finishes at Kawasan Falls, so pack a change of clothes for the end."),
            ]);
        Details("sumilon", "Oslob", extra: [new("Sanctuary since", "1974")],
            highlights:
            [
                new("The shifting sandbar", "The white sandbar changes shape with the tide and season."),
                new("Marine sanctuary", "The Philippines’ first marine sanctuary, protected since 1974. Snorkel the reef off the island."),
                new("Bangka from Oslob", "A short boat ride from the Oslob coast; tours bundle the crossing with lunch."),
            ]);
        Details("tumalog", "Oslob",
            highlights:
            [
                new("A curtain of water", "Water fans out over moss-covered rock instead of dropping in a single stream."),
                new("Shallow pool", "The basin is shallow enough to wade in under the falls."),
                new("Pair it with Sumilon", "Both are in Oslob, so they fit into the same day trip."),
            ]);
        Details("simala", "Lindogon, Sibonga", bestMonths: "Year-round",
            highlights:
            [
                new("Castle architecture", "Turrets and towers make it one of the most photographed churches on the island."),
                new("Pilgrimage site", "Devotees come to pray to the Virgin Mary and leave letters of thanks."),
                new("Dress code", "Modest dress is expected inside: cover shoulders and knees."),
            ]);
        Details("carcar", "Carcar City", bestMonths: "Year-round", secondaryCategory: "Heritage",
            highlights:
            [
                new("Chicharon", "Carcar is known for its crunchy pork chicharon, sold fresh around the public market."),
                new("Ancestral houses", "Spanish- and American-era houses line the streets around the town centre."),
                new("St. Catherine’s Church", "The town’s hilltop church faces the rotunda and plaza."),
            ]);
        Details("magellan", "Downtown Cebu City", bestMonths: "Year-round", extra: [new("Planted", "1521")],
            highlights:
            [
                new("The cross", "Erected by Magellan’s expedition in 1521 to mark Cebu’s first Christian baptisms."),
                new("Painted ceiling", "Look up inside the kiosk at the mural depicting the cross being planted."),
                new("Next to the Basilica", "Steps from the Basilica del Santo Niño, so see both in one stop."),
            ]);
        Details("basilica", "Downtown Cebu City", bestMonths: "Year-round",
            highlights:
            [
                new("The Santo Niño", "The church houses the image of the Holy Child brought to Cebu in 1521."),
                new("Heart of Sinulog", "The festival’s processions and Masses centre here every January."),
                new("Candle vendors", "Women outside sell candles and dance a prayer for you, a small Sinulog all year."),
            ]);
        Details("leah", "Busay, Cebu City", bestMonths: "Year-round",
            highlights:
            [
                new("A monument to love", "Built by Teodorico Adarna as a tribute to his late wife, Leah."),
                new("Roman-style columns", "Grand staircases, columns and statues on a hillside above the city."),
                new("City views", "Go late in the afternoon for the view over Cebu City and the harbour."),
            ]);
        Details("sirao", "Busay, Cebu City",
            highlights:
            [
                new("Celosia beds", "Terraced rows of red and yellow celosia flowers on the hillside."),
                new("“Little Amsterdam”", "Windmill-style photo spots earned the garden its nickname."),
                new("Cool hills", "Sits in the uplands above the city, noticeably cooler than downtown."),
            ]);
        Details("larsian", "Fuente Osmeña, Cebu City", bestMonths: "Year-round",
            highlights:
            [
                new("Pick your skewers", "Choose raw sticks of pork, chicken and innards from the counter and they grill them for you."),
                new("Puso", "Rice cooked in woven coconut-leaf pouches, the Cebuano way to eat barbecue."),
                new("Open late", "Busy well into the night, a classic late stop after a night out."),
            ]);
        Details("sutukil", "Mactan, Lapu-Lapu City", bestMonths: "Year-round",
            highlights:
            [
                new("Sugba, tuwa, kilaw", "Grilled, in soup or raw in vinegar: the three ways SuTuKil is named after."),
                new("Market to table", "Pick fish and shellfish at the stalls, then hand them to a restaurant to cook."),
                new("Near the airport", "On Mactan, so it works as a first or last meal in Cebu."),
            ]);
        Details("malapascua", "Daanbantayan", secondaryCategory: "Beach",
            highlights:
            [
                new("Thresher sharks", "Dawn dives at Monad Shoal for thresher sharks, one of the few places to see them daily."),
                new("Bounty Beach", "The island’s main white-sand beach, lined with dive shops and huts."),
                new("Boat from Maya", "Bangkas cross from Maya port at the northern tip of Cebu."),
            ]);
        Details("bantayan", "Santa Fe, Bantayan",
            highlights:
            [
                new("Flat and sandy", "Easy to explore by scooter or bike, with long white beaches on the Santa Fe side."),
                new("Dried fish", "Stalls along the roads sell the island’s dried fish to take home."),
                new("Ferry from Hagnaya", "Ferries run from Hagnaya port in San Remigio to Santa Fe."),
            ]);
        Details("camotes", "San Francisco, Camotes",
            highlights:
            [
                new("Lake Danao", "A large freshwater lake for boating, ringed by trees."),
                new("Timubo Cave", "Steps lead down to a clear underground pool you can swim in."),
                new("Santiago Bay", "A long white-sand bay, the islands’ best-known beach."),
            ]);
        Details("sogod", "Sogod",
            highlights:
            [
                new("Kayaking", "Paddle along a quiet stretch of coast with small coves to pull into."),
                new("Cliff jumping", "Limestone ledges over clear, deep water."),
                new("Quieter than the south", "Far fewer crowds than the Moalboal and Oslob circuit."),
            ]);

        var providers = new Dictionary<string, Provider>();
        Provider By(string name) => providers.TryGetValue(name, out var p) ? p : providers[name] = new Provider(name);

        Tours =
        [
            new() { Id = "t1", Name = "Badian Canyoneering Day Tour", Place = "Alegria to Kawasan, Badian", Region = "South Cebu", Provider = By("Matutinao Adventure Guides"), Rating = "4.9", Reviews = "612", Tag = "Most booked", Summary = "Pick-up from Moalboal, guide, helmet, life vest and lunch. Ends at Kawasan Falls.", Price = 2500, PhotoCaption = "Canyoneering group", ImageUrl = Image("badian_canyonnering.jpg"), Stops = [Get("canyon"), Get("kawasan")], EnvironmentalFee = 45 },
            new() { Id = "t2", Name = "Kawasan + Moalboal Sardine Combo", Place = "Badian & Moalboal", Region = "South Cebu", Provider = By("Panagsama Reef Tours"), Rating = "4.8", Reviews = "341", Tag = "Full day", Summary = "Morning canyoneering, afternoon snorkel with the sardine run and turtles.", Price = 3400, PhotoCaption = "Snorkelers, Moalboal", ImageUrl = Image("snorkeling.jpg"), Stops = [Get("kawasan"), Get("moalboal")], EnvironmentalFee = 45 },
            new() { Id = "t3", Name = "Easy Trail & Bamboo Raft", Place = "Kawasan Falls, Badian", Region = "South Cebu", Provider = By("Kawasan Rafters’ Association"), Rating = "4.6", Reviews = "208", Tag = "Family friendly", Summary = "Flat 20-minute walk to the falls, raft ride under the main cascade.", Price = 950, PhotoCaption = "Bamboo raft at falls", ImageUrl = Image("kawasan_bamboo_raft.jpg"), Stops = [Get("kawasan")], EnvironmentalFee = 45 },
            new() { Id = "t4", Name = "Old Cebu Heritage Walk", Place = "Cebu City", Region = "Metro Cebu", Provider = By("Parian Heritage Walks"), Rating = "4.8", Reviews = "189", Tag = "3 hours", Summary = "Magellan’s Cross, the Basilica, Fort San Pedro and the Yap-San Diego Ancestral House.", Price = 1200, PhotoCaption = "Fort San Pedro walls", ImageUrl = Image("fort san pedro.jpg"), Stops = [Get("magellan"), Get("basilica")] },
            new() { Id = "t5", Name = "Sumilon Sandbar Island Hop", Place = "Oslob", Region = "South Cebu", Provider = By("Oslob Bangkero Cooperative"), Rating = "4.7", Reviews = "274", Tag = "Half day", Summary = "Bangka to Sumilon Island, snorkel the sanctuary, then lunch on the sandbar.", Price = 1800, PhotoCaption = "Bangka at Sumilon", Stops = [Get("sumilon")] },
            new() { Id = "t6", Name = "Osmeña Peak Sunrise Hike", Place = "Mantalongon, Dalaguete", Region = "South Cebu", Provider = By("Dalaguete Mountain Guides"), Rating = "4.8", Reviews = "156", Tag = "Early start", Summary = "2:30 AM pick-up from Moalboal, guided climb, coffee at the summit.", Price = 1500, PhotoCaption = "Sunrise over Osmeña Peak", Stops = [Get("osmena")] },
        ];

        Stays =
        [
            new() { Id = "s1", Name = "Matutinao Riverside Cottage", Place = "Badian", Region = "South Cebu", Provider = By("Tabura Family Homestay"), Rating = "4.7", Reviews = "98", Tag = "Walk to falls", Summary = "Native-style room by the river trailhead. Fan, private bath, breakfast.", Price = 1800, PhotoCaption = "Riverside cottage", NearestDestination = Get("kawasan") },
            // Listed under Kawasan (25 minutes away) rather than Moalboal so it stays on the Kawasan page.
            new() { Id = "s2", Name = "Panagsama Beach Dive Lodge", Place = "Moalboal", Region = "South Cebu", Provider = By("Blue Corner Lodges"), Rating = "4.6", Reviews = "402", Tag = "Moalboal", Summary = "Air-con double steps from the sardine run. 25 minutes to Kawasan.", Price = 2600, PhotoCaption = "Dive lodge room", NearestDestination = Get("kawasan") },
            new() { Id = "s3", Name = "Badian Bay Resort Villa", Place = "Badian", Region = "South Cebu", Provider = By("Badian Bay Resorts"), Rating = "4.9", Reviews = "230", Tag = "Splurge", Summary = "Sea-view villa with pool and spa. Transfer to Kawasan included.", Price = 8900, PhotoCaption = "Resort villa pool", NearestDestination = Get("kawasan") },
            new() { Id = "s4", Name = "Parian Heritage Inn", Place = "Cebu City", Region = "Metro Cebu", Provider = By("Calle Colon Stays"), Rating = "4.5", Reviews = "311", Tag = "Downtown", Summary = "Restored 1900s house a 10-minute walk from the Basilica and Magellan’s Cross.", Price = 2200, PhotoCaption = "Heritage inn courtyard", NearestDestination = Get("basilica") },
            new() { Id = "s5", Name = "Bounty Beach Huts", Place = "Malapascua Island", Region = "North Cebu", Provider = By("Logon Beach Co."), Rating = "4.6", Reviews = "187", Tag = "Dive base", Summary = "Nipa huts on Bounty Beach. Dive shops open at 4:30 AM for thresher sharks.", Price = 1600, PhotoCaption = "Beach huts, Malapascua", NearestDestination = Get("malapascua") },
            new() { Id = "s6", Name = "Sugar Beach Cabanas", Place = "Santa Fe, Bantayan", Region = "Islands", Provider = By("Bantayan Shore Stays"), Rating = "4.7", Reviews = "144", Tag = "Sunset side", Summary = "Garden cabanas facing the west beach, scooters for rent at the gate.", Price = 3100, PhotoCaption = "Cabanas at sunset", NearestDestination = Get("bantayan") },
        ];

        Rentals =
        [
            new() { Id = "r1", Name = "Scooter 125cc", Place = "Moalboal pick-up", Region = "South Cebu", Provider = By("Moalboal Moto Rentals"), Rating = "4.7", Reviews = "520", Tag = "Self-drive", Summary = "Helmet and full tank. Driver’s licence required.", Price = 500, PhotoCaption = "Scooter", Serves = [Get("kawasan"), Get("moalboal")] },
            new() { Id = "r2", Name = "Van with Driver (up to 10)", Place = "Cebu City or Mactan Airport", Region = "Metro Cebu", Provider = By("Sugbo Transport"), Rating = "4.8", Reviews = "366", Tag = "From the city", Summary = "Door-to-door from the city or airport, fuel and tolls included.", Price = 4500, PhotoCaption = "Passenger van", Serves = [Get("kawasan"), Get("moalboal"), Get("osmena")] },
            new() { Id = "r3", Name = "Aqua Shoes & Dry Bag Set", Place = "Matutinao, Badian", Region = "South Cebu", Provider = By("Kawasan Gear Stall"), Rating = "4.5", Reviews = "129", Tag = "Gear", Summary = "Grippy shoes in all sizes and a 10L dry bag for your phone.", Price = 150, PhotoCaption = "Aqua shoes and dry bag", Serves = [Get("kawasan"), Get("canyon")] },
            new() { Id = "r4", Name = "Sedan with Driver (up to 4)", Place = "Cebu City", Region = "Metro Cebu", Provider = By("Sugbo Transport"), Rating = "4.8", Reviews = "211", Tag = "Day trips", Summary = "Ten hours of driving anywhere in Metro Cebu or as far as Oslob.", Price = 3200, PhotoCaption = "Sedan", Serves = [Get("leah"), Get("sirao"), Get("simala"), Get("carcar")] },
            new() { Id = "r5", Name = "Snorkel Mask & Fins", Place = "Panagsama Beach, Moalboal", Region = "South Cebu", Provider = By("Panagsama Reef Tours"), Rating = "4.6", Reviews = "88", Tag = "Gear", Summary = "Fitted mask, snorkel and fins for the sardine run and turtle point.", Price = 200, PhotoCaption = "Snorkel gear", Serves = [Get("moalboal")] },
            new() { Id = "r6", Name = "Private Bangka Charter (up to 8)", Place = "Mactan or Bantayan", Region = "Islands", Provider = By("Island Hopper Bangkas"), Rating = "4.7", Reviews = "173", Tag = "With crew", Summary = "Outrigger boat with captain and crew for a full day of island hopping.", Price = 5500, PhotoCaption = "Outrigger bangka", Serves = [Get("bantayan"), Get("sutukil")] },
        ];

        Offerings = [.. Tours, .. Stays, .. Rentals];
        Providers = [.. providers.Values];

        // Wire the reverse side of each relationship.
        foreach (var tour in Tours)
            foreach (var stop in tour.Stops) stop.Tours.Add(tour);
        foreach (var stay in Stays)
            stay.NearestDestination.Stays.Add(stay);
        foreach (var rental in Rentals)
            foreach (var destination in rental.Serves) destination.Rentals.Add(rental);
        foreach (var offering in Offerings)
            offering.Provider.Offerings.Add(offering);

        Collections =
        [
            new() { Title = "Island Escapes", Tagline = "Ferry-hop to sandbars, island lakes and slow white beaches.", Destinations = [.. Get("bantayan", "camotes", "sumilon", "malapascua")], MoreHref = "/explore?cat=Beach" },
            new() { Title = "Chasing Waterfalls", Tagline = "Turquoise basins and mossy curtains in the southern hills.", Destinations = [.. Get("kawasan", "tumalog", "canyon")], MoreHref = "/explore?q=falls" },
            new() { Title = "Heritage Trail", Tagline = "Five centuries of faith and trade, from the 1521 cross outward.", Destinations = [.. Get("magellan", "basilica", "simala", "carcar", "leah")], MoreHref = "/explore?cat=Heritage" },
            new() { Title = "Under the Sea", Tagline = "Sardine balls, thresher sharks and a sanctuary reef.", Destinations = [.. Get("moalboal", "malapascua", "sumilon")], MoreHref = "/explore?q=dive" },
            new() { Title = "Eat Like a Local", Tagline = "Grilled skewers, crackling chicharon and fish cooked three ways.", Destinations = [.. Get("larsian", "sutukil", "carcar")], MoreHref = "/explore?cat=Food" },
        ];
    }

    private static Destination Dest(string id, string name, string town, string region, string category, string tags, string travel, string summary, string photoCaption, string? image) =>
        new() { Id = id, Name = name, Town = town, Region = region, Category = category, Tags = tags, Travel = travel, Summary = summary, PhotoCaption = photoCaption, ImageUrl = image is null ? null : Image(image) };

    // Facts default to Location, Getting there (the card's travel time) and Best months, plus any extras;
    // pass `facts` to replace the whole list.
    private static void Details(string id, string location, Highlight[] highlights, string bestMonths = "Dec – May",
        Fact[]? extra = null, Fact[]? facts = null, string? intro = null, string? secondaryCategory = null)
    {
        var d = Get(id);
        d.Intro = intro;
        d.SecondaryCategory = secondaryCategory;
        d.Facts.AddRange(facts ?? [new("Location", location), new("Getting there", d.Travel), new("Best months", bestMonths), .. extra ?? []]);
        d.Highlights.AddRange(highlights);
    }

    private static string Image(string file) => $"images/{file}";

    public static Destination Get(string id) => Destinations.First(d => d.Id == id);

    public static Destination? GetDestination(string slug) =>
        Destinations.FirstOrDefault(d => string.Equals(d.Slug, slug, StringComparison.OrdinalIgnoreCase));

    public static IEnumerable<Destination> InSameRegion(Destination destination, int count) =>
        Destinations.Where(d => d.Region == destination.Region && d != destination).Take(count);

    public static IEnumerable<Destination> Get(params string[] ids) => ids.Select(Get);

    public static Offering[] OfferingsOf(string kind) => [.. Offerings.Where(o => o.Kind == kind)];

    public static string Peso(decimal amount) =>
        (amount < 0 ? "−" : "") + "₱" + Math.Abs(amount).ToString("N0", CultureInfo.InvariantCulture);

    public static string RegionHref(string region) => $"/explore?region={Uri.EscapeDataString(region)}";
}
