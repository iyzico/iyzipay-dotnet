using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Disapproval : IyzipayResource
    {
        public String PaymentTransactionId { get; set; }

        public static Disapproval Create(CreateApprovalRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Disapproval>(options.BaseUrl + "/payment/iyzipos/item/disapprove", GetHttpHeaders(request, options), request);
        }
    }
}
