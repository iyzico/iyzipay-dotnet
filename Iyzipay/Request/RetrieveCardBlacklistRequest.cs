using Iyzipay.Model;
using System;

namespace Iyzipay.Request
{
    public class RetrieveCardBlacklistRequest : BaseRequest
    {
        public String CardNumber { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("cardNumber", CardNumber)
                .GetRequestString();
        }
    }
}
