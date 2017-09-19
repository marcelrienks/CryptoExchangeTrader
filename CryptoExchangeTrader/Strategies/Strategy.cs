using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoExchangeTrader.Exchanges;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Stratagies
{
    public abstract class Strategy
    {
        public StrategyConfiguration StrategyConfiguration;
        public Exchange Exchange;

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
