using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class RefundChargedFromMerchant : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String PaymentTransactionId { get; set; }
        public String Price { get; set; }

        public static RefundChargedFromMerchant Create(CreateRefundRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<RefundChargedFromMerchant>("payment/iyzipos/refund/merchant/charge", GetHttpHeaders(request, options), request);
        }

        public async static Task<RefundChargedFromMerchant> CreateAsync(CreateRefundRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<RefundChargedFromMerchant>("payment/iyzipos/refund/merchant/charge", GetHttpHeaders(request, options), request);
        }
    }
}
