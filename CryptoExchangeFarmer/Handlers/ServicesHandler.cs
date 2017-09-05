using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoExchangeFarmer.Handlers
{
    public class ServicesHandler : IServicesHandler
    {
        private string _apiUrl;
        private HttpClient _client;

        /// <summary>
        /// Initialises a new Service Handler with the supplied options
        /// </summary>
        /// <param name="apiUrl">the base url for the api</param>
        /// <param name="headers">a dictionary of header names and values</param>
        public ServicesHandler(string apiUrl, Dictionary<string, string> headers = null)
        {
            _client = new HttpClient { BaseAddress = new Uri(apiUrl) };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (headers != null)
            {
                foreach (var header in headers)
                    _client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }
        }

        /// <summary>
        /// Performs a GET on the supplied path
        /// </summary>
        /// <param name="path">the path of the get</param>
        /// <returns>dynamic object representing the json result</returns>
        public async Task<dynamic> Get(string path)
        {
            //TODO: Bitfinex requires a custom header for each call that has the payload hashed in
            //find a way to make this generic, possibly adding and then removing the headers in each method.
            //possibly having a function that returns a request to the Exchange which then gets passed back down here

            var response = await _client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ExpandoObject>(json);
            }

            throw new HttpRequestException($"Service returned a {response.StatusCode} status code when performing a GET:{path}.");
        }

        /// <summary>
        /// Performs a POST on the supplied path, using the supplied body
        /// </summary>
        /// <param name="path">the path of the post</param>
        /// <param name="body">the body of the post</param>
        public async void Post(string path, HttpContent body)
        {
            var response = await _client.PostAsync(path, body);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Performs a PUT on the supplied path, using the supplied body
        /// </summary>
        /// <param name="path">the path of the put</param>
        /// <param name="body">the body of the put</param>
        public async Task<dynamic> Put(string path, HttpContent body)
        {
            var response = await _client.PostAsync(path, body);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ExpandoObject>(json);
        }

        /// <summary>
        /// Performs a DELETE on the supplied path
        /// </summary>
        /// <param name="path">the path of the delete</param>
        public async void Delete(string path)
        {
            var response = await _client.DeleteAsync(path);
            response.EnsureSuccessStatusCode();
        }
    }
}
