using CryptoExchangeFarmer.Handlers;

namespace CryptoExchangeFarmer.Exchanges
{
    public abstract class Exchange
    {
        public abstract void Initialise(IServicesHandler servicesHandler);
        public abstract object GetInvestedCoins();
        public abstract object GetTickersForCoins();
        public abstract object GetOpenTrades();

        public void Farm()
        {
            //TODO: Complete this
        }

        public void Inspect()
        {
            //TODO: Complete this
        }

        public void Buy()
        {
            //TODO: Complete this
        }

        public void Sell()
        {
            //TODO: Complete this
        }

        public void Reset()
        {
            //TODO: Complete this
        }
    }
}
