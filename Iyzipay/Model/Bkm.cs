using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Bkm : PaymentResource
    {
        public string Token { get; set; }
        public string CallbackUrl { get; set; }

        public static Task<Bkm> Retrieve(RetrieveBkmRequest request, Options options)
        {
            var uri = options.BaseUrl + "/payment/bkm/auth/detail";
            return RestHttpClientV2.Create().PostAsync<Bkm>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
        }
    }
}
