using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

using System.Threading.Tasks;

namespace Iyzipay
{
    class RestHttpClient
    {
        public static RestHttpClient Create()
        {
            return new RestHttpClient();
        }

        public async Task<T> Get<T>(String url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<T> Post<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            HttpClient httpClient = new HttpClient();
            foreach (String key in headers.Keys)
            {
                httpClient.DefaultRequestHeaders.Add(key, headers.Get(key));
            }
            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(url, JsonBuilder.ToJsonString(request));
            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<T> Delete<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            HttpClient httpClient = new HttpClient();
            foreach (String key in headers.Keys)
            {
                httpClient.DefaultRequestHeaders.Add(key, headers.Get(key));
            }
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Content = JsonBuilder.ToJsonString(request),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url)

            };
            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(requestMessage);
            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<T> Put<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            HttpClient httpClient = new HttpClient();
            foreach (String key in headers.Keys)
            {
                httpClient.DefaultRequestHeaders.Add(key, headers.Get(key));
            }
            HttpResponseMessage httpResponseMessage = await httpClient.PutAsync(url, JsonBuilder.ToJsonString(request));
            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
        }
    }
}
