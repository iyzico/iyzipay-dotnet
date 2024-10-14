using System;

namespace Iyzipay.Request
{
    public class RetrieveCardListRequest : BaseRequestV2
    {
        public string CardUserKey { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("cardUserKey", CardUserKey)
                .GetRequestString();
        }
    }
}
