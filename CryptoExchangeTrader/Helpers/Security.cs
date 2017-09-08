using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptoExchangeTrader.Helpers
{
    public static class Security
    {
        /// <summary>
        /// Generates a hash from a secret and the payload for rest API's
        /// </summary>
        /// <param name="secret">Api's secret</param>
        /// <param name="payload">the payload of the api call</param>
        /// <returns></returns>
        public static string GetHexHashSignature(string secret, string payload)
        {
            HMACSHA384 hmac = new HMACSHA384(Encoding.UTF8.GetBytes(secret));
            byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(payload));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
}
