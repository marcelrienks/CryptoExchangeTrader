using System.Collections.Generic;

namespace CryptoExchangeTrader.Models
{
    public class TradingConfiguration
    {
        public string ExchangeName { get; set; }
        public string StratagyName { get; set; }

        // API
        public string ApiUrl { get; set; }
        public Dictionary<string, string> DefaultApiHeaders { get; set; }
        public Dictionary<string, string> CustomApiSettings { get; set; }

        // Coins
        public List<string> CoinPairs { get; set; }
    }
}
