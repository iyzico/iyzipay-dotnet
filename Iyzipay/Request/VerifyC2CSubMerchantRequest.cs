using System;

namespace Iyzipay.Request
{
	public class VerifyC2CSubMerchantRequest : BaseRequest
    {
        public String TxId { get; set; }
        public String SmsVerificationCode { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("txId", TxId)
                .Append("smsVerificationCode", SmsVerificationCode)
                .GetRequestString();
        }
    }
}
