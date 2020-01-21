namespace Iyzipay.Request.V2.Subscription
{
    public class UpdateProductRequest : BaseRequestV2
    {
        public string ProductReferenceCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}