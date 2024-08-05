using System;

namespace Iyzipay.Request
{
	public class VerifyC2CSubMerchantRequest : BaseRequestV2
    {
        public string TxId { get; set; }
        public string SmsVerificationCode { get; set; }
    }
}
