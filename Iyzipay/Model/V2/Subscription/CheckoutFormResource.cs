namespace Iyzipay.Model.V2.Subscription
{
    public class CheckoutFormResource : IyzipayResourceV2
    {
        public string CheckoutFormContent { get; set; }
        public string Token { get; set; }
        public int? TokenExpireTime { get; set; }
    }
}