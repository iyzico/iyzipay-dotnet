using System;

namespace Iyzipay.Request
{
    public class RetrieveBinNumberRequest : BaseRequest
    {
        public String BinNumber { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("binNumber", BinNumber)
                .GetRequestString();
        }
    }
}
