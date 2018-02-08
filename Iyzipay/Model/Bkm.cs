using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Bkm : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }     

        public async static Task<Bkm> RetrieveAsync(RetrieveBkmRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Bkm>("payment/bkm/auth/detail", GetHttpHeaders(request, options), request);
        }

        public static Bkm Retrieve(RetrieveBkmRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Bkm>("payment/bkm/auth/detail", GetHttpHeaders(request, options), request);
        }
    }
}
