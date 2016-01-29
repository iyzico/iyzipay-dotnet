using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class Approval : IyzipayResource
    {
        public String PaymentTransactionId { get; set; }

        public static Task<Approval> Create(CreateApprovalRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<Approval>(options.BaseUrl + "/payment/iyzipos/item/approve", request);
        }
    }
}
