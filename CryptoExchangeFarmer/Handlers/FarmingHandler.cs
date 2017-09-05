using System.Collections.Generic;
using CryptoExchangeFarmer.Exchanges;

namespace CryptoExchangeFarmer.Handlers
{
    public class FarmingHandler
    {
        private List<Exchange> _exchanges;

        public FarmingHandler(List<Exchange> exchanges)
        {
            _exchanges = exchanges;
        }

        /// <summary>
        /// Run through each configured Exchange, and start Farming
        /// </summary>
        public void Farm()
        {
            foreach (var exchange in _exchanges)
            {
                exchange.Farm();
            }
        }
    }
}
