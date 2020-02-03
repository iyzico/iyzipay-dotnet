namespace Iyzipay.Request.V2.Subscription
{
    public class RetrieveAllPlanRequest : PagingRequest
    {
        public string ProductReferenceCode { get; set; }   
    }
}