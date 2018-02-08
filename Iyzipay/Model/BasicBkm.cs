using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicBkm : BasicPaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }
        public String PaymentStatus { get; set; }

        private const string RetrieveUrl = "payment/bkm/auth/detail/basic";
        public async static Task<BasicBkm> RetrieveAsync(RetrieveBkmRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<BasicBkm>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }

        public static BasicBkm Retrieve(RetrieveBkmRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<BasicBkm>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
