using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Iyzipay
{
    class BaseHttpClient
    {
        public async Task<T> Get<T>(String url)
        {
            HttpResponseMessage httpResponseMessage = await  new HttpClient().GetAsync(url);
            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<T> Post<T>(String url, BaseRequest request)
        {
            HttpResponseMessage httpResponseMessage = await new HttpClient().PostAsync(url, JsonBuilder.ToJsonString(request));
            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<T> Delete<T>(String url, BaseRequest request)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Content = JsonBuilder.ToJsonString(request),
                Method=HttpMethod.Delete,
                RequestUri=new Uri(url)

            };
            HttpResponseMessage httpResponseMessage = await new HttpClient().SendAsync(requestMessage);
            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<T> Put<T>(String url, BaseRequest request)
        {
            HttpResponseMessage httpResponseMessage = await new HttpClient().PutAsync(url, JsonBuilder.ToJsonString(request));
            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
        }
    }
}
