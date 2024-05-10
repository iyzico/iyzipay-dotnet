using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PayWithIyzico : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }      

        public static Task<PayWithIyzico> Retrieve(RetrievePayWithIyzicoRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<PayWithIyzico>(options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }
    }
}
