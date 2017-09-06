using CryptoExchangeFarmer.Handlers;
using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Exchanges
{
    public abstract class Exchange
    {
        protected ExchangeConfiguration _exchangeConfiguration;
        IServicesHandler _servicesHandler;

        protected Exchange(ExchangeConfiguration exchangeConfiguration, IServicesHandler servicesHandler)
        {
            _exchangeConfiguration = exchangeConfiguration;
            _servicesHandler = servicesHandler;
        }

        #region MyRegion

        public abstract object GetTickersForConfiguredCoins();
        public abstract object GetInvestedCoinBalances();
        public abstract object GetOpenTrades();

        #endregion
    }
}
