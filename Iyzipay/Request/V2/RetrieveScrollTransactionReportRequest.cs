namespace Iyzipay.Request.V2
{
	public class RetrieveScrollTransactionReportRequest : BaseRequestV2
    {
        public string DocumentScrollVoSortingOrder { get; set; }
        public string TransactionDate { get; set; }
        public long? LastId { get; set; }
        public string ConversationId { get; set; }
    }
}