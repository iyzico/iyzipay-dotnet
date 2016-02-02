using Iyzipay.Request;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    class ThreeDSInitialize : IyzipayResource
    {
        [JsonProperty(PropertyName ="threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        public static ThreeDSInitialize Create(CreateThreeDSInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ThreeDSInitialize>(options.BaseUrl + "/payment/iyzipos/initialize3ds/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
