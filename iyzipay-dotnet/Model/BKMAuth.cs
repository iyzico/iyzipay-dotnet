using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class BKMAuth : Payment
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }
        public String PaymentStatus { get; set; }

        public static Task<BKMAuth> Retrieve(RetrieveBKMAuthRequest request, Options options)
        {
            return new RestHttpClient().Post<BKMAuth>(options.BaseUrl + "/payment/iyzipos/bkm/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }
    }
}
