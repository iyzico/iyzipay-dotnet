using System;

namespace Iyzipay.Request
{
    public class CreateConnectThreeDSInitializeRequest : CreateConnectPaymentRequest
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
