using Iyzipay.Request;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    class ConnectThreeDSInitialize : IyzipayResource
    {
        [JsonProperty(PropertyName ="threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        public static Task<ConnectThreeDSInitialize> Create(CreateConnectThreeDSInitializeRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ConnectThreeDSInitialize>(options.BaseUrl + "/payment/iyziconnect/initialize3ds", request);
        }
    }
}
