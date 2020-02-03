using Newtonsoft.Json;

namespace Iyzipay.Model.V2.Iyzilink
{
    public class IyziLinkItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        
        [JsonProperty(PropertyName = "currencyCode")]
        public string Currency { get; set; }
        
        public string Token { get; set; }
        
        [JsonProperty(PropertyName = "productStatus")]
        public IyziLinkStatus IyziLinkStatus { get; set; }
        
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public bool? AddressIgnorable { get; set; }
        public int? SoldCount { get; set; }
        public int? SoldLimit { get; set; }
        public int? RemainingSoldLimit { get; set; }
        public bool? InstallmentRequested { get; set; }
    }
}