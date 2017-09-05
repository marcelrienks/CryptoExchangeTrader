using System;
using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Exchanges
{
    public class Bitfinex : Exchange
    {
        private ExchangeConfiguration _exchangeConfiguration;

        /// <summary>
        /// Initialise a Bitfinex Exchange
        /// </summary>
        /// <param name="exchangeConfiguration"></param>
        public override void Initialise(ExchangeConfiguration exchangeConfiguration)
        {
            _exchangeConfiguration = exchangeConfiguration;
        }

        public override object GetTickers()
        {
            throw new NotImplementedException();
        }
    }
}
