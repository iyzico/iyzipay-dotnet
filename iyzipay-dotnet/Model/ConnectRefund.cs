using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectRefund : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String PaymentTransactionId { get; set; }
        public decimal? Price { get; set; }
        public String ConnectorName { get; set; }

        public static Task<ConnectRefund> Create(CreateRefundRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ConnectRefund>(options.BaseUrl + "/payment/iyziconnect/refund", request);
        }
    }
}
