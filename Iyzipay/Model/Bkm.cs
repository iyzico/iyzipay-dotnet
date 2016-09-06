using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class Bkm : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }     

        public static Bkm Retrieve(RetrieveBkmRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Bkm>(options.BaseUrl + "/payment/bkm/auth/detail", GetHttpHeaders(request, options), request);
        }
    }
}
