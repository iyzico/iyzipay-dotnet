using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectCancel : IyzipayResource
    {
        public String PaymentId { get; set; }
        public decimal? Price { get; set; }
        public String ConnectorName { get; set; }

        public static Task<ConnectCancel> Create(CreateCancelRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ConnectCancel>(options.BaseUrl + "/payment/iyziconnect/cancel", request);
        }
    }
}
