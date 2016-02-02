using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class ConnectBKMInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }

        public static ConnectBKMInitialize Create(CreateConnectBKMInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectBKMInitialize>(options.BaseUrl + "/payment/iyziconnect/bkm/initialize", GetHttpHeaders(request, options), request);
        }
    }
}
