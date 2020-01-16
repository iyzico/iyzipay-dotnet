using Iyzipay.Request;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public class CardManagementRetrieveCardBuilder : BaseRequestBuilder
    {
        private string _pageToken;

        public static CardManagementRetrieveCardBuilder Create()
        {
            return new CardManagementRetrieveCardBuilder();
        }

        public CardManagementRetrieveCardBuilder PageToken(string pageToken)
        {
            _pageToken = pageToken;
            return this;
        }

        public RetrieveCardManagementPageCardRequest Build()
        {
            return new RetrieveCardManagementPageCardRequest
            {
                PageToken = _pageToken, 
                ConversationId = _conversationId, 
                Locale = _locale
            };
        }
    }
}