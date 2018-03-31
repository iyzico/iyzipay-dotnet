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
#if !NETSTANDARD
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
#endif
        }

        public static RestHttpClient Create()
        {
            return new RestHttpClient();
        }

        public T Get<T>(String url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponseMessage = httpClient.GetAsync(url).Result;

                return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            }
        }

        public T Post<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                foreach (String key in headers.AllKeys)
                {
                    httpClient.DefaultRequestHeaders.Add(key, headers[key]);
                }

                HttpResponseMessage httpResponseMessage = httpClient.PostAsync(url, JsonBuilder.ToJsonString(request)).Result;
                return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            }
        }

        public T Delete<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                foreach (String key in headers.AllKeys)
                {
                    httpClient.DefaultRequestHeaders.Add(key, headers[key]);
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
        }

        public T Put<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                foreach (String key in headers.AllKeys)
                {
                    httpClient.DefaultRequestHeaders.Add(key, headers[key]);
                }

                HttpResponseMessage httpResponseMessage = httpClient.PutAsync(url, JsonBuilder.ToJsonString(request)).Result;
                return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
