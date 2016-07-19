// <copyright file="RestHttpClient.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay
{
    using System;
    using System.Net;
    using System.Net.Http;
    using Newtonsoft.Json;

    /// <summary>
    /// REST HTTP Client
    /// </summary>
    public class RestHttpClient
    {
        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <returns>A new instance</returns>
        public static RestHttpClient Create()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            return new RestHttpClient();
        }

        /// <summary>
        /// Gets the specified URL.
        /// </summary>
        /// <typeparam name="T">Type parameter for the method</typeparam>
        /// <param name="url">The URL.</param>
        /// <returns>The response</returns>
        public T Get<T>(string url)
        {
            var httpClient = new HttpClient();
            var httpResponseMessage = httpClient.GetAsync(url).Result;

            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }

        /// <summary>
        /// Posts the specified URL.
        /// </summary>
        /// <typeparam name="T">Type parameter for the method</typeparam>
        /// <param name="url">The URL.</param>
        /// <param name="headers">The headers.</param>
        /// <param name="request">The request.</param>
        /// <returns>The response</returns>
        public T Post<T>(string url, WebHeaderCollection headers, BaseRequest request)
        {
            var httpClient = new HttpClient();
            foreach (string key in headers.Keys)
            {
                httpClient.DefaultRequestHeaders.Add(key, headers.Get(key));
            }

            var httpResponseMessage = httpClient.PostAsync(url, JsonBuilder.ToJsonString(request)).Result;
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }

        /// <summary>
        /// Deletes the specified URL.
        /// </summary>
        /// <typeparam name="T">Type parameter for the method</typeparam>
        /// <param name="url">The URL.</param>
        /// <param name="headers">The headers.</param>
        /// <param name="request">The request.</param>
        /// <returns>The response</returns>
        public T Delete<T>(string url, WebHeaderCollection headers, BaseRequest request)
        {
            var httpClient = new HttpClient();
            foreach (string key in headers.Keys)
            {
                httpClient.DefaultRequestHeaders.Add(key, headers.Get(key));
            }

            var requestMessage = new HttpRequestMessage
            {
                Content = JsonBuilder.ToJsonString(request),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url)
            };
            var httpResponseMessage = httpClient.SendAsync(requestMessage).Result;
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }

        /// <summary>
        /// Puts the specified URL.
        /// </summary>
        /// <typeparam name="T">Type parameter for the method</typeparam>
        /// <param name="url">The URL.</param>
        /// <param name="headers">The headers.</param>
        /// <param name="request">The request.</param>
        /// <returns>The response</returns>
        public T Put<T>(string url, WebHeaderCollection headers, BaseRequest request)
        {
            var httpClient = new HttpClient();
            foreach (string key in headers.Keys)
            {
                httpClient.DefaultRequestHeaders.Add(key, headers.Get(key));
            }

            var httpResponseMessage = httpClient.PutAsync(url, JsonBuilder.ToJsonString(request)).Result;
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
    }
}
