using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchangeTrader.Exchanges
{
    public class Dummy : IExchange
    {
        public object GetInvestedCoinBalances()
        {
            throw new NotImplementedException();
        }

        public object GetLastTradesForConfiguredCoins()
        {
            throw new NotImplementedException();
        }

        public object GetOpenTrades()
        {
            throw new NotImplementedException();
        }

        public object GetTickersForConfiguredCoins()
        {
            throw new NotImplementedException();
        }
    }
}
