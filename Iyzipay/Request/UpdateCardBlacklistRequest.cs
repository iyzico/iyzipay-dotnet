using Iyzipay.Model;
using System;

namespace Iyzipay.Request
{
    public class UpdateCardBlacklistRequest : BaseRequestV2
    {
        public string CardToken { get; set; }
        public string CardUserKey { get; set; }


        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("cardToken", CardToken)
                .Append("cardUserKey", CardUserKey)
                .GetRequestString();
        }
    }
}
