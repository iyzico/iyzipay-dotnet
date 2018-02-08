using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class ThreedsInitializePreAuth : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        private const string CreateUrl = "payment/3dsecure/initialize/preauth";

        public static ThreedsInitializePreAuth Create(CreatePaymentRequest request, Options options)
        {
            ThreedsInitializePreAuth response = RestHttpClient.Create(options.BaseUrl).Post<ThreedsInitializePreAuth>(CreateUrl, GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }

        public async static Task<ThreedsInitializePreAuth> CreateAsync(CreatePaymentRequest request, Options options)
        {
            ThreedsInitializePreAuth response = await RestHttpClient.Create(options.BaseUrl).PostAsync<ThreedsInitializePreAuth>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
