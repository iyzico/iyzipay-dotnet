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
        static RestHttpClientV2()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static RestHttpClientV2 Create()
        {
            return new RestHttpClientV2();
        }

        public T Get<T>(String url, WebHeaderCollection headers) where T : IyzipayResourceV2
        {
            HttpClient httpClient = new HttpClient();
            foreach (String key in headers.Keys)
            {
                httpClient.DefaultRequestHeaders.Add(key, headers.Get(key));
            }

            HttpResponseMessage httpResponseMessage = httpClient.GetAsync(url).Result;
            var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            response.AppendWithHttpResponseHeaders(httpResponseMessage);
            return response;
        }
    }
}
