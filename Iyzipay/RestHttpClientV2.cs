﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Threading.Tasks;

namespace Iyzipay
{
	class RestHttpClientV2
	{
		private static readonly HttpClient HttpClient;
		static RestHttpClientV2()
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			HttpClient = new HttpClient();
		}

		public static RestHttpClientV2 Create()
		{
			return new RestHttpClientV2();
		}

		public T Get<T>(String url, Dictionary<string, string> headers) where T : IyzipayResourceV2
		{
			HttpRequestMessage requestMessage = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(url)

			};

			foreach (var header in headers)
			{
				requestMessage.Headers.Add(header.Key, header.Value);
			}

			HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
			var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
			response.AppendWithHttpResponseHeaders(httpResponseMessage);
			return response;
		}

		public T Post<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
		{
			HttpRequestMessage requestMessage = new HttpRequestMessage
			{
				Method = HttpMethod.Post,
				RequestUri = new Uri(url),
				Content = JsonBuilder.ToJsonString(request)
			};

			foreach (var header in headers)
			{
				requestMessage.Headers.Add(header.Key, header.Value);
			}

			HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
			var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
			response.AppendWithHttpResponseHeaders(httpResponseMessage);
			return response;
		}
		public async Task<T> PostAsync<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
		{
			HttpRequestMessage requestMessage = new HttpRequestMessage
			{
				Method = HttpMethod.Post,
				RequestUri = new Uri(url),
				Content = JsonBuilder.ToJsonString(request)
			};

			foreach (var header in headers)
			{
				requestMessage.Headers.Add(header.Key, header.Value);
			}

			HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
			var readAsString = await httpResponseMessage.Content.ReadAsStringAsync();
			var response = JsonConvert.DeserializeObject<T>(readAsString);
			response.AppendWithHttpResponseHeaders(httpResponseMessage);
			return response;
		}

		public T Put<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
		{
			HttpRequestMessage requestMessage = new HttpRequestMessage
			{
				Method = HttpMethod.Put,
				RequestUri = new Uri(url),
				Content = JsonBuilder.ToJsonString(request)
			};

			foreach (var header in headers)
			{
				requestMessage.Headers.Add(header.Key, header.Value);
			}

			HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
			var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
			response.AppendWithHttpResponseHeaders(httpResponseMessage);
			return response;
		}

		public async Task<T> PutAsync<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
		{
			HttpRequestMessage requestMessage = new HttpRequestMessage
			{
				Method = HttpMethod.Put,
				RequestUri = new Uri(url),
				Content = JsonBuilder.ToJsonString(request)
			};

			foreach (var header in headers)
			{
				requestMessage.Headers.Add(header.Key, header.Value);
			}

			HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
			var readAsString = await httpResponseMessage.Content.ReadAsStringAsync();
			var response = JsonConvert.DeserializeObject<T>(readAsString);
			response.AppendWithHttpResponseHeaders(httpResponseMessage);
			return response;
		}


		public T Patch<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Put,//todo: [EY] Patch olarak değiştirilmeli fakat kütüphane güncellenmesi gerekiyor.
                RequestUri = new Uri(url),
                Content = JsonBuilder.ToJsonString(request)
            };

            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
            var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            response.AppendWithHttpResponseHeaders(httpResponseMessage);
            return response;
        }

		public T Delete<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
		{
			HttpRequestMessage requestMessage = new HttpRequestMessage
			{
				Method = HttpMethod.Delete,
				RequestUri = new Uri(url),
				Content = JsonBuilder.ToJsonString(request)
			};

			foreach (var header in headers)
			{
				requestMessage.Headers.Add(header.Key, header.Value);
			}

			HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
			var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
			response.AppendWithHttpResponseHeaders(httpResponseMessage);
			return response;
		}

		public async Task<T> DeleteAsync<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
		{
			HttpRequestMessage requestMessage = new HttpRequestMessage
			{
				Method = HttpMethod.Delete,
				RequestUri = new Uri(url),
				Content = JsonBuilder.ToJsonString(request)
			};

			foreach (var header in headers)
			{
				requestMessage.Headers.Add(header.Key, header.Value);
			}

			HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
			var readAsString = await httpResponseMessage.Content.ReadAsStringAsync();
			var response = JsonConvert.DeserializeObject<T>(readAsString);
			response.AppendWithHttpResponseHeaders(httpResponseMessage);
			return response;
		}
	}
}
