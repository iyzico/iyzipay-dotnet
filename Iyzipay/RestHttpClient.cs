using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Iyzipay
{
    public class RestHttpClient
    {
        private static readonly HttpClient HttpClient;
        static RestHttpClient()
        {
#if !NETSTANDARD
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
#endif
            
            HttpClient = new HttpClient();
        }

        public static RestHttpClient Create()
        {
            return new RestHttpClient();
        }

        public T Get<T>(String url)
        {
            HttpResponseMessage httpResponseMessage = HttpClient.GetAsync(url).Result; 
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
        
        public async Task<T> GetAsync<T>(String url)
        {
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
        }

        public T Post<T>(String url, WebHeaderCollection headers, BaseRequest request)
        { 
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post, 
                RequestUri = new Uri(url), 
                Content = JsonBuilder.ToJsonString(request)
            };
            
            foreach (String key in headers.AllKeys) 
            {
                requestMessage.Headers.Add(key, headers[key]); 
            }
            
            HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }

        public T Delete<T>(String url, WebHeaderCollection headers, BaseRequest request)
        { 
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url)

            };
            
            foreach (String key in headers.AllKeys)
            {
                requestMessage.Headers.Add(key, headers[key]); 
            }
            
            HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result; 
            HttpResponseMessage httpResponseMessage = HttpClient.DeleteAsync(requestMessage).Result; 
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }

        public T Put<T>(String url, WebHeaderCollection headers, BaseRequest request)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Put, 
                RequestUri = new Uri(url), 
                Content = JsonBuilder.ToJsonString(request)
            };
            
            foreach (String key in headers.AllKeys) 
            {
                requestMessage.Headers.Add(key, headers[key]); 
            }
            
            HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result; 
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
    }
}
