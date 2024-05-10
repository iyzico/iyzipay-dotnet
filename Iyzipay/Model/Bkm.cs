using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Bkm : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }     

        public static Task<Bkm> Retrieve(RetrieveBkmRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<Bkm>(options.BaseUrl + "/payment/bkm/auth/detail", GetHttpHeaders(request, options), request);
        }
    }
}
