static class AppraisalTool
{
    public static Dictionary<string, double> Catalogue = new() {
        { "The Hope Diamond", 250_000_000 },
        { "The Mona Lisa", 50_000_000 },
        { "Tutankhamun's Mask", 5_000_000 },
        { "The Dead Sea Scrolls (Fragment)", 1_500_000 },
        { "A Roman Gladiator's Helmet", 1_000_000 },
        { "The Gutenberg Bible (Single Page)", 500_000 },
        { "A Viking Longship Fragment", 300_000 },
        { "An Ancient Greek Amphora", 200_000 },
        { "Rare stamp (1851 10c green)", 1_000 },
        { "A Samurai Katana from the Edo Period", 150_000 },
        { "A Pre-Columbian Gold Figurine", 100_000 },
    };

    static void Main()
    {
        Console.WriteLine("Appraising listed artifacts...");
        List<Artifact> listedArtifacts = [
            new("The Hope Diamond", 1),
            new("A Pre-Columbian Gold Figurine", 0),
            new("The Dead Sea Scrolls (Fragment)", 0.5),
            new("An Ancient Greek Amphora", 0.75),
        ];
        
        foreach (var artifact in listedArtifacts)
        {
            Appraise(artifact);
        }
        
        Console.WriteLine("\nAppraising unlisted artifacts...");
        List<Artifact> unlistedArtifacts = [
            new("Gom Jabbar", 1),
            new("Invisibility Cloak", 0.9),
            new("The Praetor Suit", 1),
            new("The Master Sword", 0),
        ];
        
        foreach (var artifact in unlistedArtifacts)
        {
            Appraise(artifact);
        }
        
        Console.WriteLine("\nAdding artifacts...");
        AddArtifact("Orb of Dragonkind", 2_000_000);
        AddArtifact("The Hope Diamond", 250_000_000);
        AddArtifact(" Leoric's Crown  ", 1_000_000);
        AddArtifact("  The Gutenberg Bible (Single Page) ", 500_000);
        
        Console.WriteLine("\nPrinting Catalogue...");
        PrintCatalogue();
    }
    
    // Your valuable code goes here
    public static void Appraise(Artifact artifact)
    {
        string price;
        if (Catalogue.ContainsKey(artifact.Name))
        {
            price = $": {Convert.ToString(Catalogue[artifact.Name] * artifact.ConditionRate)}";
        }
        else
        {
            price = "not in catalogue";
        }
        Console.WriteLine($"Value of artifact'{artifact.Name}' {price}");
    }

    public static void AddArtifact(string name, double value)
    {
        name = name.Trim();
        if (!Catalogue.ContainsKey(name))
        {
            Catalogue.Add(name, value);
            Console.WriteLine($"Added artifact '{name}'");
        }
        else
        {
            Console.WriteLine($"Artifact '{name}' already in catalogue");
        }
    }

    public static void PrintCatalogue()
    {
        Console.WriteLine("Catalogue:");
        foreach(KeyValuePair<string, double> item in Catalogue)
        {
            Console.WriteLine($" - Artifact '{item.Key}', Perfect Condition Value: {item.Value}");
        }
    }
}
