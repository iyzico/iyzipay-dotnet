using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class ConnectBKMAuth : ConnectPayment
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }
        public String PaymentStatus { get; set; }

        public static ConnectBKMAuth Retrieve(RetrieveBKMAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectBKMAuth>(options.BaseUrl + "/payment/iyziconnect/bkm/auth/detail", GetHttpHeaders(request, options), request);
        }
    }
}
