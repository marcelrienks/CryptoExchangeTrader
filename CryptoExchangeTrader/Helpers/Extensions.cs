using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoExchangeTrader.Helpers
{
    public static class Extensions
    {
        /// <summary>
        /// Extension method that will allow for an Action to be passed in that accepts an HttpRequestMessage object, which can then be modified before the message is sent.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="path">The Uri the request is sent to</param>
        /// <param name="modifyMessageAction">Action method that accepts an HttpRequestMessage object, which can then be modified before the message is sent</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> GetAsync(this HttpClient httpClient, string path, Action<HttpRequestMessage> modifyMessageAction)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, path);

            modifyMessageAction(httpRequestMessage);

            return httpClient.SendAsync(httpRequestMessage);
        }

        /// <summary>
        /// /// Extension method that will allow for an Action to be passed in that accepts an HttpRequestMessage object, which can then be modified before the message is sent.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="path">The Uri the request is sent to</param>
        /// <param name="body">The HTTP request content sent to teh server</param>
        /// <param name="modifyMessageAction">Action method that accepts an HttpRequestMessage object, which can then be modified before the message is sent</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> PostAsync(this HttpClient httpClient, string path, HttpContent body, Action<HttpRequestMessage> modifyMessageAction)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, path) { Content = body };

            modifyMessageAction(httpRequestMessage);

            return httpClient.SendAsync(httpRequestMessage);
        }

        /// <summary>
        /// /// Extension method that will allow for an Action to be passed in that accepts an HttpRequestMessage object, which can then be modified before the message is sent.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="path">The Uri the request is sent to</param>
        /// <param name="body">The HTTP request content sent to teh server</param>
        /// <param name="modifyMessageAction">Action method that accepts an HttpRequestMessage object, which can then be modified before the message is sent</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> PutAsync(this HttpClient httpClient, string path, HttpContent body, Action<HttpRequestMessage> modifyMessageAction)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, path) { Content = body };

            modifyMessageAction(httpRequestMessage);

            return httpClient.SendAsync(httpRequestMessage);
        }

        /// <summary>
        /// /// Extension method that will allow for an Action to be passed in that accepts an HttpRequestMessage object, which can then be modified before the message is sent.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="path">The Uri the request is sent to</param>
        /// <param name="modifyMessageAction">Action method that accepts an HttpRequestMessage object, which can then be modified before the message is sent</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> DeleteAsync(this HttpClient httpClient, string path, Action<HttpRequestMessage> modifyMessageAction)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, path);

            modifyMessageAction(httpRequestMessage);

            return httpClient.SendAsync(httpRequestMessage);
        }
    }
}
