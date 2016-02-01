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

        public static Task<ThreeDSInitialize> Create(CreateThreeDSInitializeRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ThreeDSInitialize>(options.BaseUrl + "/payment/iyzipos/initialize3ds/ecom", request);
        }
    }
}
