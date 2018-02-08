using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Bkm : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }

        private const string RetrieveUrl = "payment/bkm/auth/detail";
        public async static Task<Bkm> RetrieveAsync(RetrieveBkmRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Bkm>(RetrieveUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static Bkm Retrieve(RetrieveBkmRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Bkm>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
