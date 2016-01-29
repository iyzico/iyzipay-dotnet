using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class Disapproval : IyzipayResource
    {
        public String PaymentTransactionId { get; set; }

        public static Task<Disapproval> Create(CreateApprovalRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<Disapproval>(options.BaseUrl + "/payment/iyzipos/item/disapprove", request);
        }
    }
}
