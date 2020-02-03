namespace Iyzipay.Request.V2.Subscription
{
    public class CancelSubscriptionRequest : BaseRequestV2
    {
        public string SubscriptionReferenceCode { get; set; }
    }
}