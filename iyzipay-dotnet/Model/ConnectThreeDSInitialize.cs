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

        public static ConnectThreeDSInitialize Create(CreateConnectThreeDSInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectThreeDSInitialize>(options.BaseUrl + "/payment/iyziconnect/initialize3ds", GetHttpHeaders(request, options), request);
        }
    }
}
