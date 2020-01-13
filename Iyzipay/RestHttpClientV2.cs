using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;

namespace Iyzipay
{
    class RestHttpClientV2
    {
        private static readonly HttpClient HttpClient;
        static RestHttpClientV2()
        {
#if !NETSTANDARD
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
#endif
            
            HttpClient = new HttpClient();
        }

        public static RestHttpClientV2 Create()
        {
            return new RestHttpClientV2();
        }

        public T Get<T>(String url, WebHeaderCollection headers) where T : IyzipayResourceV2
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)

            };
            
            foreach (String key in headers.AllKeys)
            {
                requestMessage.Headers.Add(key, headers[key]); 
            }

            HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
            var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            response.AppendWithHttpResponseHeaders(httpResponseMessage);
            return response;
        }

        public T Post<T>(String url, WebHeaderCollection headers, BaseRequestV2 request) where T : IyzipayResourceV2
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
            var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            response.AppendWithHttpResponseHeaders(httpResponseMessage);
            return response;
        }
    }
}
