using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class PeccoPayment : PaymentResource
    {
        public String Token { get; set; }

        public static PeccoPayment Create(CreatePeccoPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PeccoPayment>(options.BaseUrl + "/payment/pecco/auth", GetHttpHeaders(request, options), request);
        }
    }
}
