using System.Collections.Generic;
using CryptoExchangeTrader.Exchanges;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Stratagies
{
    public abstract class Strategy
    {
        public StrategyConfiguration StrategyConfiguration;
        public Exchange Exchange;

        public List<Balance> InvestedBalances;
        public List<Trade> OpenTrades;
        public List<Trade> LastTrades;
        public List<Ticker> Tickers;

        /// <summary>
        /// Construct a concrete Strategy
        /// </summary>
        /// <param name="exchange">concrete dependency injected Exchange</param>
        public Strategy(StrategyConfiguration strategyConfiguration, Exchange exchange)
        {
            StrategyConfiguration = strategyConfiguration;
            Exchange = exchange;
        }

        #region Abstract

        public abstract void ExecuteStrategy();
        
        #endregion
    }
}
