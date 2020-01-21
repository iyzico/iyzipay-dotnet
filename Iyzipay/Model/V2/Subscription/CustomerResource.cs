namespace Iyzipay.Model.V2.Subscription
{
    public class CustomerResource
    {
        public string ReferenceCode { get; set; }
        public long? CreatedDate { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string GsmNumber { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
    }
}