using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class Bkm : PaymentResource
    {
        public string Token { get; set; }
        public string CallbackUrl { get; set; }     

        public static Bkm Retrieve(RetrieveBkmRequest request, Options options)
        {
            var uri = options.BaseUrl + "/payment/bkm/auth/detail";
            return RestHttpClientV2.Create().Post<Bkm>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
        }
    }
}
