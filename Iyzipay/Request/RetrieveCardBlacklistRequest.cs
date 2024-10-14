using Iyzipay.Model;
using System;

namespace Iyzipay.Request
{
    public class RetrieveCardBlacklistRequest : BaseRequestV2
    {
        public string CardNumber { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("cardNumber", CardNumber)
                .GetRequestString();
        }
    }
}
