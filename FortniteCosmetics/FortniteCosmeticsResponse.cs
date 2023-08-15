using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteAPI_V2
{
    public class FortniteCosmeticsResponse
    {
        public int status { get; set; }
        public List<FortniteCosmeticItem> data { get; set; }
    }

    public class FortniteCosmeticItem
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public CosmeticType type { get; set; }
        public CosmeticRarity rarity { get; set; }
        public CosmeticImages images { get; set; }
        // Add more properties as needed
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

    public class CosmeticImages
    {
        public string smallIcon { get; set; }
        // Add more image properties as needed
    }
}
