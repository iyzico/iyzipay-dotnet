using System;

namespace Iyzipay.Request
{
    public class DeleteCardRequest : BaseRequest
    {
        public String CardUserKey { get; set; }
        public String CardToken { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("cardUserKey", CardUserKey)
                .Append("cardToken", CardToken)
                .GetRequestString();
        }
    }
}
