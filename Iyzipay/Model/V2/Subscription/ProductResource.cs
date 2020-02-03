using System.Collections.Generic;

namespace Iyzipay.Model.V2.Subscription
{
    public class ProductResource
    {
        public string ReferenceCode { get; set; }
        public long? CreatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Plan> PricingPlans { get; set; }
    }
}