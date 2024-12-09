using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using System.Text;

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
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };
            var content = new StringContent(JsonConvert.SerializeObject(request, settings), Encoding.UTF8, "application/json");

            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Content = content
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
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };
            var content = new StringContent(JsonConvert.SerializeObject(request, settings), Encoding.UTF8, "application/json");

            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Content = content
            };

            foreach (var header in headers)
			{
				requestMessage.Headers.Add(header.Key, header.Value);
			}

			HttpResponseMessage httpResponseMessage = await HttpClient.SendAsync(requestMessage);
			var readAsString = await httpResponseMessage.Content.ReadAsStringAsync();
			var response = JsonConvert.DeserializeObject<T>(readAsString);
			response.AppendWithHttpResponseHeaders(httpResponseMessage);
			return response;
		}

		public T Put<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
		{
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };
            var content = new StringContent(JsonConvert.SerializeObject(request, settings), Encoding.UTF8, "application/json");

            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Content = content
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
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };
            var content = new StringContent(JsonConvert.SerializeObject(request, settings), Encoding.UTF8, "application/json");

            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Content = content
            };

            foreach (var header in headers)
			{
				requestMessage.Headers.Add(header.Key, header.Value);
			}

			HttpResponseMessage httpResponseMessage = await HttpClient.SendAsync(requestMessage);
			var readAsString = await httpResponseMessage.Content.ReadAsStringAsync();
			var response = JsonConvert.DeserializeObject<T>(readAsString);
			response.AppendWithHttpResponseHeaders(httpResponseMessage);
			return response;
		}


		public T Patch<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };
            var content = new StringContent(JsonConvert.SerializeObject(request, settings), Encoding.UTF8, "application/json");

            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Content = content
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
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };
            var content = new StringContent(JsonConvert.SerializeObject(request, settings), Encoding.UTF8, "application/json");

            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url),
                Content = content
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
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };
            var content = new StringContent(JsonConvert.SerializeObject(request, settings), Encoding.UTF8, "application/json");

            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url),
                Content = content
            };

            foreach (var header in headers)
			{
				requestMessage.Headers.Add(header.Key, header.Value);
			}

			HttpResponseMessage httpResponseMessage = await HttpClient .SendAsync(requestMessage);
			var readAsString = await httpResponseMessage.Content.ReadAsStringAsync();
			var response = JsonConvert.DeserializeObject<T>(readAsString);
			response.AppendWithHttpResponseHeaders(httpResponseMessage);
			return response;
		}
	}
}
