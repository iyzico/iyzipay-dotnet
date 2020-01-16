using Iyzipay.Request;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public sealed class RetrieveIyziupFormRequestBuilder : BaseRequestBuilder
        {
            private string _token;
            
            private RetrieveIyziupFormRequestBuilder()
            {
            }

            public static RetrieveIyziupFormRequestBuilder Create()
            {
                return new RetrieveIyziupFormRequestBuilder();
            }
            
            public RetrieveIyziupFormRequestBuilder Token(string token)
            {
                this._token = token;
                return this;
            }

            public RetrieveIyziupFormRequest Build()
            {
                RetrieveIyziupFormRequest retrieveIyziupFormRequest = new RetrieveIyziupFormRequest();
                retrieveIyziupFormRequest.Locale = _locale;
                retrieveIyziupFormRequest.ConversationId = _conversationId;
                retrieveIyziupFormRequest.Token = _token;
                return retrieveIyziupFormRequest;
            }
        } 
    }