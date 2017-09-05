using System.Collections.Generic;

namespace CryptoExchangeFarmer.Models
{
    public class ExchangeConfiguration
    {
        public string Name { get; set; }

        // API
        public string ApiUrl { get; set; }
        public Dictionary<string, string> ApiHeaders { get; set; }
        public Dictionary<string, string> Custom { get; set; }

        // Coins
        public List<string> CoinPairs { get; set; }
    }
}
