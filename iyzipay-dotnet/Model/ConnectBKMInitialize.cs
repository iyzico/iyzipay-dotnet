using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectBKMInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }

        public static Task<ConnectBKMInitialize> Create(CreateConnectBKMInitializeRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ConnectBKMInitialize>(options.BaseUrl + "/payment/iyziconnect/bkm/initialize", request);
        }
    }
}
