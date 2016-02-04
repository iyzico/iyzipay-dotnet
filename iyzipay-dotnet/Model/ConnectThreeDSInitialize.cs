using Iyzipay.Request;
using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    public class ConnectThreeDSInitialize : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        public static ConnectThreeDSInitialize Create(CreateConnectThreeDSInitializeRequest request, Options options)
        {
            ConnectThreeDSInitialize response = RestHttpClient.Create().Post<ConnectThreeDSInitialize>(options.BaseUrl + "/payment/iyziconnect/initialize3ds", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.decodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
