using System;

namespace Iyzipay.Request
{
    public class UpdatePaymentItemRequest : BaseRequestV2
    {
        public string SubMerchantKey { get; set; }
        public string PaymentTransactionId { get; set; }
        public string SubMerchantPrice { get; set; }


        public override string ToPKIRequestString()
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
