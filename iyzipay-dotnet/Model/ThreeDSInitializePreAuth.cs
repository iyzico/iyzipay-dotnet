using Iyzipay.Request;
using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    public class ThreeDSInitializePreAuth : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        public static ThreeDSInitializePreAuth Create(CreateThreeDSInitializeRequest request, Options options)
        {
            ThreeDSInitializePreAuth response = RestHttpClient.Create().Post<ThreeDSInitializePreAuth>(options.BaseUrl + "/payment/iyzipos/initialize3ds/preauth/ecom", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.decodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
