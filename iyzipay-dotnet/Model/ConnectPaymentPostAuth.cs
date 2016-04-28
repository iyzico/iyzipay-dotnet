using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class ConnectPaymentPostAuth : ConnectPayment
    {
        public static ConnectPaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectPaymentPostAuth>(options.BaseUrl + "/payment/iyziconnect/postauth", GetHttpHeaders(request, options), request);
        }
    }
}
