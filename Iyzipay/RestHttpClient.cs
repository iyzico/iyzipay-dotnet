using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Iyzipay
{
    public class RestHttpClient
    {
        private static readonly HttpClient _httpClient;

        static RestHttpClient()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-iyzi-client-version", "iyzipay-dotnet-2.1.13");
        }
        private RestHttpClient(string baseUrl)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri(baseUrl);
            }
            
        }
        public static RestHttpClient Create(string baseUrl)
        {
            
            return new RestHttpClient(baseUrl);
            
        }        

        public async Task<T> GetAsync<T>(String url)
        {
            var httpMessage = new HttpRequestMessage(HttpMethod.Get, url);

            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(url).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false));
        }

        public T Get<T>(String url)
        {
            var httpMessage = new HttpRequestMessage(HttpMethod.Get, url);

            HttpResponseMessage httpResponseMessage = _httpClient.GetAsync(url).Result;

            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }

        public async Task<T> PostAsync<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            return await SendHttpRequestAsync<T>(url, HttpMethod.Post, headers, request);
        }

        public T Post<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            return SendHttpRequestAsync<T>(url, HttpMethod.Post, headers, request).Result;
        }

        public async Task<T> DeleteAsync<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            return await SendHttpRequestAsync<T>(url, HttpMethod.Delete, headers, request);
        }

        public T Delete<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            return SendHttpRequestAsync<T>(url, HttpMethod.Delete, headers, request).Result;
        }

        public async Task<T> PutAsync<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            return await SendHttpRequestAsync<T>(url, HttpMethod.Put, headers, request);
        }

        public T Put<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            return SendHttpRequestAsync<T>(url, HttpMethod.Put, headers, request).Result;
        }

        public async Task<T> SendHttpRequestAsync<T>(string url, HttpMethod method, WebHeaderCollection headers, BaseRequest request)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Content = JsonBuilder.ToJsonString(request),
                Method = method,
                RequestUri = new Uri(url, UriKind.Relative)
            };
            foreach (String key in headers.Keys)
            {
                requestMessage.Headers.Add(key, headers.Get(key));
            }
            HttpResponseMessage httpResponseMessage = await _httpClient.SendAsync(requestMessage).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false));
        }
    }
}
