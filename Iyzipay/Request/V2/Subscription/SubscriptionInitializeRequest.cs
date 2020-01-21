namespace Iyzipay.Request.V2.Subscription
{
    public class SubscriptionInitializeRequest : BaseRequestV2
    {
        public string PricingPlanReferenceCode { get; set; }
        public string SubscriptionInitialStatus { get; set; }
        public CheckoutFormCustomer Customer { get; set; }
        public CardInfo PaymentCard { get; set; }
    }

    public class CardInfo
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpireYear { get; set; }
        public string ExpireMonth { get; set; }
        public string Cvc { get; set; }
        public bool RegisterConsumerCard { get; set; }
        public string UcsToken { get; set; }
        public string CardToken { get; set; }
        public string ConsumerToken { get; set; }
    }
}