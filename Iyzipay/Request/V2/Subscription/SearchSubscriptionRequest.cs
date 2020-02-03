namespace Iyzipay.Request.V2.Subscription
{
    public class SearchSubscriptionRequest : PagingRequest
    {
        public string SubscriptionReferenceCode { get; set; }
        public string ParentReferenceCode { get; set; }
        public string CustomerReferenceCode { get; set; }
        public string PricingPlanReferenceCode { get; set; }
        public string SubscriptionStatus { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}