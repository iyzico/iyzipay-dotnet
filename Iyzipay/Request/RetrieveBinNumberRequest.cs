using System;

namespace Iyzipay.Request
{
    public class RetrieveBinNumberRequest : BaseRequestV2
    {
        public string BinNumber { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("binNumber", BinNumber)
                .GetRequestString();
        }
    }
}
