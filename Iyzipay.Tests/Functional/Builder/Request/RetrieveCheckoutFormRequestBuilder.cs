using Iyzipay.Request;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public sealed class RetrieveCheckoutFormRequestBuilder : BaseRequestBuilder
    {
        private string _token;

        private RetrieveCheckoutFormRequestBuilder()
        {
        }

        public static RetrieveCheckoutFormRequestBuilder Create()
        {
            return new RetrieveCheckoutFormRequestBuilder();
        }

        public RetrieveCheckoutFormRequestBuilder Token(string token)
        {
            this._token = token;
            return this;
        }

        public RetrieveCheckoutFormRequest Build()
        {
            RetrieveCheckoutFormRequest retrieveCheckoutFormRequest = new RetrieveCheckoutFormRequest();
            retrieveCheckoutFormRequest.Locale = _locale;
            retrieveCheckoutFormRequest.ConversationId = _conversationId;
            retrieveCheckoutFormRequest.Token = _token;
            return retrieveCheckoutFormRequest;
        }
    }
}
