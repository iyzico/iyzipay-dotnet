using System;

namespace Iyzipay.Request
{
    public class DeleteCardRequest : BaseRequestV2
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }


        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("cardUserKey", CardUserKey)
                .Append("cardToken", CardToken)
                .GetRequestString();
        }
    }
}
