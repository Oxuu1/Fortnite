public class FortniteCosmeticItem
{
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public CosmeticType type { get; set; }
    public CosmeticRarity rarity { get; set; }
    public object series { get; set; }
    public CosmeticSet set { get; set; }
    public Introduction introduction { get; set; }
    public Images images { get; set; }
    public int price { get; set; } // Add the price property
}


public class CosmeticType
{
    public string value { get; set; }
    public string displayValue { get; set; }
    public string backendValue { get; set; }
}

public class CosmeticRarity
{
    public string value { get; set; }
    public string displayValue { get; set; }
    public string backendValue { get; set; }
}

public class CosmeticSet
{
    public string value { get; set; }
    public string text { get; set; }
    public string backendValue { get; set; }
}

public class Introduction
{
    public string chapter { get; set; }
    public string season { get; set; }
    public string text { get; set; }
    public int backendValue { get; set; }
}

public class Images
{
    public string smallIcon { get; set; }
    // Add other image properties here if needed
}
