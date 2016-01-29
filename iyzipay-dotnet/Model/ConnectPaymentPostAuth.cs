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

        public static Task<ConnectPaymentPostAuth> Create(CreatePaymentPostAuthRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ConnectPaymentPostAuth>(options.BaseUrl + "/payment/iyziconnect/postauth", request);
        }
    }
}
