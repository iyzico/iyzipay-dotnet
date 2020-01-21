namespace Iyzipay.Model.V2.Subscription
{
    public class PlanResource
    {
        public string ReferenceCode { get; set; }
        public long? CreatedDate { get; set; }
        public string Name { get; set; }
        public string ProductReferenceCode { get; set; }
        public string Price { get; set; }
        public string CurrencyCode { get; set; }
        public string PaymentInterval { get; set; }
        public int? PaymentIntervalCount { get; set; }
        public int? TrialPeriodDays { get; set; }
        public string PlanPaymentType { get; set; }
        public int? RecurrenceCount { get; set; }
        public string Status { get; set; }
    }
}