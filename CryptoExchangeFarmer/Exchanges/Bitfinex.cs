using System;
using System.Security.Cryptography;
using System.Text;
using CryptoExchangeFarmer.Handlers;

namespace CryptoExchangeFarmer.Exchanges
{
    public class Bitfinex : Exchange
    {
        private IServicesHandler _servicesHandler;

        #region Public

        /// <summary>
        /// Initialise a Bitfinex Exchange
        /// </summary>
        /// <param name="exchangeConfiguration"></param>
        public override void Initialise(IServicesHandler servicesHandler)
        {
            _servicesHandler = servicesHandler;
        }

        public override object GetInvestedCoins()
        {
            throw new NotImplementedException();
        }

        public override object GetTickersForCoins()
        {
            // Call api to get tickers
            var path = "";
            _servicesHandler.Get(path);

            // Convert Bitfinex tickers to model
            return "";
        }

        public override object GetOpenTrades()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private

        //TODO: Complete this
        //private string GetHexHashSignature(string payload)
        //{
        //    HMACSHA384 hmac = new HMACSHA384(Encoding.UTF8.GetBytes(_apiSecret));
        //    byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(payload));
        //    return BitConverter.ToString(hash).Replace("-", "").ToLower();
        //}

        #endregion
    }
}
