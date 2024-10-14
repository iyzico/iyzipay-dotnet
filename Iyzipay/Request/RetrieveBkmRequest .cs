using System;

namespace Iyzipay.Request
{
    public class RetrieveBkmRequest : BaseRequestV2
    {
        public string Token { set; get; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("token", Token)
                .GetRequestString();
        }
    }
}
