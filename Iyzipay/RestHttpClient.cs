using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

namespace Iyzipay
{
    public class RestHttpClient
    {
        static RestHttpClient()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static RestHttpClient Create()
        {
            return new RestHttpClient();
        }

        public T Get<T>(String url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync(url).Result;

            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }

        public T Post<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            HttpClient httpClient = new HttpClient();
            foreach (String key in headers.Keys)
            {
                httpClient.DefaultRequestHeaders.Add(key, headers.Get(key));
            }
            HttpResponseMessage httpResponseMessage = httpClient.PostAsync(url, JsonBuilder.ToJsonString(request)).Result;
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }

        public T Delete<T>(String url, WebHeaderCollection headers, BaseRequest request)
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
            HttpResponseMessage httpResponseMessage = httpClient.SendAsync(requestMessage).Result;
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }

        public T Put<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            HttpClient httpClient = new HttpClient();
            foreach (String key in headers.Keys)
            {
                httpClient.DefaultRequestHeaders.Add(key, headers.Get(key));
            }
            HttpResponseMessage httpResponseMessage = httpClient.PutAsync(url, JsonBuilder.ToJsonString(request)).Result;
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
    }
}
