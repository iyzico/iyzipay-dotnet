using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectPaymentPostAuth : IyzipayResource
    {
        public String PaymentId { get; set; }
        public decimal? Price { get; set; }
        public String ConnectorName { get; set; }

        public static ConnectPaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectPaymentPostAuth>(options.BaseUrl + "/payment/iyziconnect/postauth", GetHttpHeaders(request, options), request);
        }
    }
}
