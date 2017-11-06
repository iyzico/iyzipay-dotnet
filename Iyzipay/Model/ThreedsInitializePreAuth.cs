using Iyzipay.Request;
using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    public class ThreedsInitializePreAuth : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        public static ThreedsInitializePreAuth Create(CreatePaymentRequest request, Options options)
        {
            ThreedsInitializePreAuth response = RestHttpClient.Create().Post<ThreedsInitializePreAuth>(options.BaseUrl + "/payment/3dsecure/initialize/preauth", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
