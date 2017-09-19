using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoExchangeTrader.Handlers;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Exchanges
{
    public class Dummy : Exchange
    {
        /// <summary>
        /// Initialise a Dummy Exchange used for testing
        /// </summary>
        /// <param name="tradingConfiguration">concrete dependency injected TradingConfiguration</param>
        /// <param name="servicesHandler">concrete dependency injected ServicesHandler</param>
        public Dummy(ExchangeConfiguration exchangeConfiguration, ServicesHandler servicesHandler) : base(exchangeConfiguration, servicesHandler)
        {
        }

        #region Public

        public override object GetInvestedBalancesForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        public override object GetLastTradeForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        public override object GetOpenTradeForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        public override object GetTickersForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
