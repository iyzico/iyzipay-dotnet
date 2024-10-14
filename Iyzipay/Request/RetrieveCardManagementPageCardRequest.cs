using System;

namespace Iyzipay.Request
{
    public class RetrieveCardManagementPageCardRequest : BaseRequest
    {
        public string PageToken { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("token", PageToken)
                .GetRequestString();
        }
    }
}
