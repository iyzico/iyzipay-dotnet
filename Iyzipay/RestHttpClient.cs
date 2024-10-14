using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

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

		public T Get<T>(string url)
		{
			using (var httpClient = new HttpClient())
			{
				HttpResponseMessage httpResponseMessage = httpClient.GetAsync(url).Result;
				return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
			}
		}

		public T Get<T>(string url, Dictionary<string, string> headers)
		{
			using (var httpClient = new HttpClient())
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

				HttpResponseMessage httpResponseMessage = httpClient.SendAsync(requestMessage).Result;
				return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
			}
		}

		public T Post<T>(string url, Dictionary<string, string> headers, BaseRequest request)
		{
			using (var httpClient = new HttpClient())
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

				HttpResponseMessage httpResponseMessage = httpClient.SendAsync(requestMessage).Result;
				return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
			}
		}
		public async Task<T> PostAsync<T>(string url, Dictionary<string, string> headers, BaseRequest request)
		{
			using (var httpClient = new HttpClient())
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

				HttpResponseMessage httpResponseMessage = httpClient.SendAsync(requestMessage).Result;
				var responseString = await httpResponseMessage.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T>(responseString);
			}
		}

		public T Delete<T>(string url, Dictionary<string, string> headers, BaseRequest request)
		{
			using (var httpClient = new HttpClient())
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

				HttpResponseMessage httpResponseMessage = httpClient.SendAsync(requestMessage).Result;
				return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
			}
		}
		public async Task<T> DeleteAsync<T>(string url, Dictionary<string, string> headers, BaseRequest request)
		{
			using (var httpClient = new HttpClient())
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

				HttpResponseMessage httpResponseMessage = httpClient.SendAsync(requestMessage).Result;
				var responseString = await httpResponseMessage.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T>(responseString);
			}
		}

		public T Put<T>(string url, Dictionary<string, string> headers, BaseRequest request)
		{
			using (var httpClient = new HttpClient())
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

				HttpResponseMessage httpResponseMessage = httpClient.SendAsync(requestMessage).Result;
				return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
			}
		}
		public async Task<T> PutAsync<T>(string url, Dictionary<string, string> headers, BaseRequest request)
		{
			using (var httpClient = new HttpClient())
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

				HttpResponseMessage httpResponseMessage = httpClient.SendAsync(requestMessage).Result;
				var responseString = await httpResponseMessage.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T>(responseString);
			}
		}
	}
}
