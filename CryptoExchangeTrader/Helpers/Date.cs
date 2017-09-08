using System;

namespace CryptoExchangeTrader.Helpers
{
    public static class Date
    {
        /// <summary>
        /// Generate a Nonce number
        /// </summary>
        /// <returns>unix epoch date time used as a nonce</returns>
        public static long GenerateNonce()
        {
            var currentTime = DateTime.Now.ToUniversalTime();
            var unixEpoch = new DateTime(1970, 1, 1);
            return (long)(currentTime.Subtract(unixEpoch)).TotalSeconds;
        }
    }
}
