using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class Approval : IyzipayResource
    {
        public String PaymentTransactionId { get; set; }

        public static Approval Create(CreateApprovalRequest request, Options options)
        {
            return  RestHttpClient.Create().Post<Approval>(options.BaseUrl + "/payment/iyzipos/item/approve", GetHttpHeaders(request, options), request);
        }
    }
}
