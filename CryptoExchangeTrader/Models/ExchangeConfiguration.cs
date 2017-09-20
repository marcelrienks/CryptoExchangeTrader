using System.Collections.Generic;

namespace CryptoExchangeTrader.Models
{
    public class ExchangeConfiguration
    {
        public string Name { get; set; }

        // API
        public string ApiUrl { get; set; }
        public Dictionary<string, string> DefaultApiHeaders { get; set; }
        public Dictionary<string, string> CustomApiSettings { get; set; }

        // Coins
        public List<string> CoinPairs { get; set; }
    }
}
