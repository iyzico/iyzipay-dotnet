using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Approval : IyzipayResource
    {
        private const string CreateUrl = "payment/iyzipos/item/approve";
        public String PaymentTransactionId { get; set; }

        public static Approval Create(CreateApprovalRequest request, Options options)
        {
            return  RestHttpClient.Create(options.BaseUrl).Post<Approval>(CreateUrl, GetHttpHeaders(request, options), request);
        }

        public async static Task<Approval> CreateAsync(CreateApprovalRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Approval>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
