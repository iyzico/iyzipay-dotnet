namespace Iyzipay.Request.V2.Subscription
{
    public class SubscriptionInitializeWithCustomerRequest : BaseRequestV2
    {
        public string SubscriptionInitialStatus { get; set; }
        public string PricingPlanReferenceCode { get; set; }
        public string CustomerReferenceCode { get; set; }
    }
}