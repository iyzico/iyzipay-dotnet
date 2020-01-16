using System;

namespace Iyzipay.Request
{
    public class UpdatePaymentItemRequest : BaseRequest
    {
        public String SubMerchantKey { get; set; }
        public String PaymentTransactionId { get; set; }
        public String SubMerchantPrice { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("subMerchantKey", SubMerchantKey)
                .Append("paymentTransactionId", PaymentTransactionId)
                .Append("subMerchantPrice", SubMerchantPrice)
                .GetRequestString();
        }
    }
}
