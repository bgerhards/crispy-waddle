using System;
using System.Net.Http;
using System.Threading.Tasks;
using Crispy_Waddle_Console.Data;

namespace Crispy_Waddle_Console_Tests.TestUtilities
{
    public class MockHttpClientHandler: IHttpHandler
    {
        public MockHttpClientHandler()
        {
        }

        public HttpResponseMessage Get(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync(string url)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage Post(string url, HttpContent content)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            throw new NotImplementedException();
        }
    }
}
