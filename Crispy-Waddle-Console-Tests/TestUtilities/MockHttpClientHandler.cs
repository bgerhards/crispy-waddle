using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Crispy_Waddle_Console.Application.Data;
using Crispy_Waddle_Console.Application.Models;
using Newtonsoft.Json;

namespace Crispy_Waddle_Console_Tests.TestUtilities
{
    public class MockHttpClientHandler: IHttpHandler
    {
        public MockHttpClientHandler()
        {
        }

        public HttpResponseMessage Get(string url)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            string content;
            if (containsAlbumId(url))
            {
                content = MockDataFactory.GetAllMockDataAsStringByAlbumId(GetAlbumIdFromUrlAsInt(url));
            }
            else
            {
                content = MockDataFactory.GetAllMockDataAsString();
            }
            httpResponseMessage.Content = new StringContent(content);
            return httpResponseMessage;
        }

        public async Task<T> Get<T>(string url)
        {
            string content;
            if (containsAlbumId(url))
            {
                content = MockDataFactory.GetAllMockDataAsStringByAlbumId(GetAlbumIdFromUrlAsInt(url));
            } else
            {
                content = MockDataFactory.GetAllMockDataAsString();
            }
            return await Task.Run(() => JsonConvert.DeserializeObject<T>(content));
        }

        private bool containsAlbumId(string url)
        {
            Uri myUri = new Uri(url);
            string param = HttpUtility.ParseQueryString(myUri.Query).Get("albumId");
            return !string.IsNullOrEmpty(param);
        }

        private string GetAlbumIdFromUrl(string url)
        {
            Uri myUri = new Uri(url);
            return HttpUtility.ParseQueryString(myUri.Query).Get("albumId");
        }

        private int GetAlbumIdFromUrlAsInt(string url)
        {
            int intAlbumId = int.Parse(GetAlbumIdFromUrl(url));
            return intAlbumId;
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
