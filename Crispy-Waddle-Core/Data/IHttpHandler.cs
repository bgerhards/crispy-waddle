using System.Net.Http;
using System.Threading.Tasks;

namespace Crispy_Waddle_Core.Data
{
    public interface IHttpHandler
    {
        HttpResponseMessage Get(string url);
        Task<T> Get<T>(string url);
        HttpResponseMessage Post(string url, HttpContent content);
        Task<HttpResponseMessage> GetAsync(string url);
        Task<HttpResponseMessage> PostAsync(string url, HttpContent content);

    }
}
