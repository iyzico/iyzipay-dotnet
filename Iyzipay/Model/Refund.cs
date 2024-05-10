using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Refund : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String PaymentTransactionId { get; set; }
        public String Price { get; set; }
        public String Currency { get; set; }
        public String ConnectorName { get; set; }
        public String AuthCode { get; set; }
        public String HostReference { get; set; }

        public static Task<Refund> Create(CreateRefundRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<Refund>(options.BaseUrl + "/payment/refund", GetHttpHeaders(request, options), request);
        }

        public static Task<Refund> CreateAmountBasedRefundRequest(CreateAmountBasedRefundRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<Refund>(options.BaseUrl + "/v2/payment/refund", GetHttpHeaders(request, options), request);
        }

    }
}
