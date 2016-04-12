using Iyzipay.Request;
using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    public class ConnectThreeDSInitializePreAuth : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        public static ConnectThreeDSInitializePreAuth Create(CreateConnectThreeDSInitializeRequest request, Options options)
        {
            ConnectThreeDSInitializePreAuth response = RestHttpClient.Create().Post<ConnectThreeDSInitializePreAuth>(options.BaseUrl + "/payment/iyziconnect/initialize3ds/preauth", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.decodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
