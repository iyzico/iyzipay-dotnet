using Iyzipay.Model;
using System;

namespace Iyzipay.Request
{
    public class UpdateCardBlacklistRequest : BaseRequest
    {
        public String CardToken { get; set; }
        public String CardUserKey { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("cardToken", CardToken)
                .Append("cardUserKey", CardUserKey)
                .GetRequestString();
        }
    }
}
