using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Disapproval : IyzipayResource
    {
        public String PaymentTransactionId { get; set; }

        public async static Task<Disapproval> CreateAsync(CreateApprovalRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Disapproval>("payment/iyzipos/item/disapprove", GetHttpHeaders(request, options), request);
        }

        public static Disapproval Create(CreateApprovalRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Disapproval>("payment/iyzipos/item/disapprove", GetHttpHeaders(request, options), request);
        }
    }
}
