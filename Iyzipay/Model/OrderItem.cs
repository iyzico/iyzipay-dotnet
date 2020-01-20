using System;

namespace Iyzipay.Model
{
    public class OrderItem :  RequestStringConvertible
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Category1 { get; set; }
        public String Category2 { get; set; }
        public String ItemType { get; set; }
        public String ItemUrl { get; set; }
        public String ItemDescription { get; set; }
        public String Price { get; set; }
        
        public string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("id", Id)
                .Append("name", Name)
                .Append("category1", Category1)
                .Append("category2", Category2)
                .Append("itemType", ItemType)
                .Append("itemUrl", ItemUrl)
                .Append("itemDescription", ItemDescription)
                .AppendPrice("price", Price)
        
                .GetRequestString();
        }
    }
}