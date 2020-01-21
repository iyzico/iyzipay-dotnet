using Iyzipay.Model;

namespace Iyzipay.Request.V2.Subscription
{
    public class UpdateCustomerRequest : BaseRequestV2
    {
        public string CustomerReferenceCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
    }
}