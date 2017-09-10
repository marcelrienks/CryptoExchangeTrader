using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchangeTrader.Exchanges
{
    public class Dummy : IExchange
    {
        public object GetInvestedBalancesForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        public object GetLastTradeForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        public object GetOpenTradeForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        public object GetTickersForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }
    }
}
