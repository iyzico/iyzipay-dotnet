using System;

namespace Iyzipay
{
    public class PagingRequest : BaseRequestV2
    {
        public int? Page { get; set; }
        public int? Count { get; set; }
        
        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("page", Page)           
                .Append("count", Count)           
                .GetRequestString();
        }
    }
}