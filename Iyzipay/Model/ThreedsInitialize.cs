using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class ThreedsInitialize : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        private const string CreateUrl = "payment/3dsecure/initialize";
        public static ThreedsInitialize Create(CreatePaymentRequest request, Options options)
        {
            ThreedsInitialize response = RestHttpClient.Create(options.BaseUrl).Post<ThreedsInitialize>(CreateUrl, GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }

        public async static Task<ThreedsInitialize> CreateAsync(CreatePaymentRequest request, Options options)
        {
            ThreedsInitialize response = await RestHttpClient.Create(options.BaseUrl).PostAsync<ThreedsInitialize>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
