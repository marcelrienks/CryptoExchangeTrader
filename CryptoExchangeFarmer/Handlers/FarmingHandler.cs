using System;
using System.Collections.Generic;
using System.Text;
using CryptoExchangeFarmer.Interfaces;

namespace CryptoExchangeFarmer.Handlers
{
    public class FarmingHandler
    {
        private IExchange _exchange;

        public FarmingHandler(IExchange exchange)
        {
            _exchange = exchange;
        }

        public void Inspect()
        {

        }

        public void Farm()
        {

        }

        public void Reset()
        {

        }
    }
}
