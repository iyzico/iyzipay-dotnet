namespace Iyzipay.Model.V2.Subscription
{
    public class SubscriptionCreatedResource
    {
        public string ReferenceCode { get; set; }
        public string ParentReferenceCode { get; set; }
        public string PricingPlanReferenceCode { get; set; }
        public string CustomerReferenceCode { get; set; }
        public string SubscriptionStatus { get; set; }
        public int? TrialDays { get; set; }
        public long? TrialStartDate { get; set; }
        public long? TrialEndDate { get; set; }
        public long? CreatedDate { get; set; }
        public long? StartDate { get; set; }
    }
}