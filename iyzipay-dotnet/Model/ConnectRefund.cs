using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class ConnectRefund : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String PaymentTransactionId { get; set; }
        public String Price { get; set; }
        public String ConnectorName { get; set; }

        public static ConnectRefund Create(CreateRefundRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectRefund>(options.BaseUrl + "/payment/iyziconnect/refund", GetHttpHeaders(request, options), request);
        }
    }
}
