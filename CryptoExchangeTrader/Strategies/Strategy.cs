using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoExchangeTrader.Exchanges;

namespace CryptoExchangeTrader.Stratagies
{
    public abstract class Strategy
    {
        public Exchange _exchange;

        /// <summary>
        /// Construct a concrete Strategy
        /// </summary>
        /// <param name="exchange">concrete dependency injected Exchange</param>
        public Strategy(Exchange exchange)
        {
            _exchange = exchange;
        }

        #region Abstract

        public abstract void ExecuteStrategy();
        
        #endregion
    }
}
