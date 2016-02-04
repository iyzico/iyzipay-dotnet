using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class ConnectPaymentPostAuth : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String Price { get; set; }
        public String ConnectorName { get; set; }

        public static ConnectPaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectPaymentPostAuth>(options.BaseUrl + "/payment/iyziconnect/postauth", GetHttpHeaders(request, options), request);
        }
    }
}
