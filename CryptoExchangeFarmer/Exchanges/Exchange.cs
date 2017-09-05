using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Exchanges
{
    public abstract class Exchange
    {
        public abstract void Initialise(ExchangeConfiguration exchangeConfiguration);
        public abstract object GetTickers();

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
