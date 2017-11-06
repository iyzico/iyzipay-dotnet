using Iyzipay.Request;
using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    public class BasicThreedsInitializePreAuth : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        public static BasicThreedsInitializePreAuth Create(CreateBasicPaymentRequest request, Options options)
        {
            BasicThreedsInitializePreAuth response = RestHttpClient.Create().Post<BasicThreedsInitializePreAuth>(options.BaseUrl + "/payment/3dsecure/initialize/preauth/basic", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
