using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Exchanges
{
    public abstract class Exchange
    {
        public abstract void Initialise(ExchangeConfiguration exchangeConfiguration);
        public abstract object GetTickers();

        public void Farm()
        {

        }

        public void Inspect()
        {

        }

        public void Buy()
        {

        }

        public void Sell()
        {

        }

        public void Reset()
        {

        }
    }
}
