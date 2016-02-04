using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class ConnectBKMInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }

        public static ConnectBKMInitialize Create(CreateConnectBKMInitializeRequest request, Options options)
        {
            ConnectBKMInitialize response = RestHttpClient.Create().Post<ConnectBKMInitialize>(options.BaseUrl + "/payment/iyziconnect/bkm/initialize", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.decodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
