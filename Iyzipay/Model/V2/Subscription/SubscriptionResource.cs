using System.Collections.Generic;
using Newtonsoft.Json;

namespace Iyzipay.Model.V2.Subscription
{
    public class SubscriptionResource : SubscriptionCreatedResource
    {
        public string CustomerEmail { get; set; }
        
        [JsonProperty(PropertyName = "orders")]
        public List<SubscriptionOrder> SubscriptionOrders { get; set; }
    }
}