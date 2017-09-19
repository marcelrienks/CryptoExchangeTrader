using System.Collections.Generic;

namespace CryptoExchangeTrader.Models
{
    public class TradingConfiguration
    {
        //TODO: Break this up into Exchange Settings, and Strategy Settings, and pass each one into their respective Concrete class, rather then the full config object

        public ExchangeConfiguration Exchange { get; set; }
        public StrategyConfiguration Strategy { get; set; }

        public Mode TradingMode { get; set; }
    }
}
