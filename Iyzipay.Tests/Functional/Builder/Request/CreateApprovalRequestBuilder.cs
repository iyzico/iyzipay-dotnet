using Iyzipay.Request;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public sealed class CreateApprovalRequestBuilder : BaseRequestBuilder
    {
        private string _paymentTransactionId;

        private CreateApprovalRequestBuilder()
        {
        }

        public static CreateApprovalRequestBuilder Create()
        {
            return new CreateApprovalRequestBuilder();
        }


        public CreateApprovalRequestBuilder PaymentTransactionId(string paymentTransactionId)
        {
            _paymentTransactionId = paymentTransactionId;
            return this;
        }

        public CreateApprovalRequest Build()
        {
            CreateApprovalRequest createApprovalRequest = new CreateApprovalRequest();
            createApprovalRequest.Locale = _locale;
            createApprovalRequest.ConversationId =  _conversationId;
            createApprovalRequest.PaymentTransactionId = _paymentTransactionId;
            return createApprovalRequest;
        }
    }
}
