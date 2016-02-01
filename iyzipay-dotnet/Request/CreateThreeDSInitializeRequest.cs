using System;

namespace Iyzipay.Request
{
    public class CreateThreeDSInitializeRequest : CreatePaymentRequest
    {
        public String CallbackUrl { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("callbackUrl", CallbackUrl)
                .GetRequestString();
        }
    }
}
