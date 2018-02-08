using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Disapproval : IyzipayResource
    {
        public String PaymentTransactionId { get; set; }

        private const string CreateUrl = "payment/iyzipos/item/disapprove";
        public async static Task<Disapproval> CreateAsync(CreateApprovalRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Disapproval>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static Disapproval Create(CreateApprovalRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Disapproval>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
