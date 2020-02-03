namespace Iyzipay.Request.V2.Subscription
{
    public class UpgradeSubscriptionRequest : BaseRequestV2
    {
        public string SubscriptionReferenceCode { get; set; }
        public string NewPricingPlanReferenceCode { get; set; }
        public string UpgradePeriod { get; set; }
        public bool UseTrial { get; set; }
        public bool ResetRecurrenceCount { get; set; }
    }
}