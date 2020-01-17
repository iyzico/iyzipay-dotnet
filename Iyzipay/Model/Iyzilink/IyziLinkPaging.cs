using System.Collections.Generic;
using Newtonsoft.Json;

namespace Iyzipay.Model.Iyzilink
{
    public class IyziLinkPaging
    {
        [JsonProperty(PropertyName = "items")]
        public List<IyziLinkItem> IyziLinkItems { get; set; }
        
        public long? TotalCount { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageCount { get; set; }
    }
}