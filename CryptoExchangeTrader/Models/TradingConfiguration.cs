using System.Collections.Generic;

namespace CryptoExchangeTrader.Models
{
    public class TradingConfiguration
    {
        //TODO: Break this up into Exchange Settings, and Strategy Settings, and pass each one into their respective Concrete class, rather then the full config object
        public string ExchangeName { get; set; }
        public string StrategyName { get; set; }
        public Mode TradingMode { get; set; }

        // API
        public string ApiUrl { get; set; }
        public Dictionary<string, string> DefaultApiHeaders { get; set; }
        public Dictionary<string, string> CustomApiSettings { get; set; }

        // Coins
        public List<string> CoinPairs { get; set; }
    }
}
