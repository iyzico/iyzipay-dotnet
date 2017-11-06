using Iyzipay.Request;
using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    public class BasicThreedsInitialize : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        public static BasicThreedsInitialize Create(CreateBasicPaymentRequest request, Options options)
        {
            BasicThreedsInitialize response = RestHttpClient.Create().Post<BasicThreedsInitialize>(options.BaseUrl + "/payment/3dsecure/initialize/basic", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
