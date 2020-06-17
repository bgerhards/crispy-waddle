using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Crispy_Waddle_Console.Application.Data
{
    public class HttpClientHandler: IHttpHandler
    {
        private readonly HttpClient _httpClient;

        public HttpClientHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public HttpResponseMessage Get(string url)
        {
            return GetAsync(url).Result;
        }

        public HttpResponseMessage Post(string url, HttpContent content)
        {
            return PostAsync(url, content).Result;
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _httpClient.GetAsync(url);
        }

        public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            return await _httpClient.PostAsync(url, content);
        }

        public async Task<T> Get<T>(string url)
        {
            var responseMessage = Get(url);
            var content = await responseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
