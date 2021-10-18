using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace lesson10.Servises
{
    public class HttpClientService
    {
        private readonly HttpClient _client;

        public HttpClientService()
        {
            _client = new HttpClient();
        }
        public async Task<T> GetObjectAsync<T>(string url)
        {
            var uri = new Uri(url);

            using var httpResponse = await _client.GetAsync(uri);

        }
    }
}