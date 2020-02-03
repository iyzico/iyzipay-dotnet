using System.Collections.Generic;

namespace Iyzipay.Model.V2
{
    public class ResponsePagingData<T> : IyzipayResourceV2
    {
        public ResponsePaging<T> Data { get; set; }
    }
    
    public class ResponsePaging<T>
    {
        public List<T> Items { get; set; }
        public long? TotalCount { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageCount { get; set; }
    }
}