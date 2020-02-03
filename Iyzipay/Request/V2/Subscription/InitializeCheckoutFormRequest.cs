using Iyzipay.Model;

namespace Iyzipay.Request.V2.Subscription
{
    public class InitializeCheckoutFormRequest : BaseRequestV2
    {
        public string CallbackUrl { get; set; }
        public string PricingPlanReferenceCode { get; set; }
        public string SubscriptionInitialStatus { get; set; }
        public CheckoutFormCustomer Customer { get; set; }
    }

    public class CheckoutFormCustomer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string GsmNumber { get; set; }
        public string IdentityNumber { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
    }
}