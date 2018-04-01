using Iyzipay.Model;
using Iyzipay.Request;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public sealed class CreateCardRequestBuilder : BaseRequestBuilder
    {
        private string _email;
        private string _cardUserKey;
        private CardInformation _card;
        private string _externalId;

        private CreateCardRequestBuilder()
        {
        }

        public static CreateCardRequestBuilder Create()
        {
            return new CreateCardRequestBuilder();
        }

        public CreateCardRequestBuilder ExternalId(string externalId)
        {
            _externalId = externalId;
            return this;
        }

        public CreateCardRequestBuilder Email(string email)
        {
            _email = email;
            return this;
        }

        public CreateCardRequestBuilder CardUserKey(string cardUserKey)
        {
            _cardUserKey = cardUserKey;
            return this;
        }

        public CreateCardRequestBuilder Card(CardInformation card)
        {
            _card = card;
            return this;
        }

        public CreateCardRequest Build()
        {
            CreateCardRequest createCardRequest = new CreateCardRequest();
            createCardRequest.Locale = Locale;
            createCardRequest.ConversationId = ConversationId;
            createCardRequest.ExternalId = _externalId;
            createCardRequest.Email = _email;
            createCardRequest.CardUserKey = _cardUserKey;
            createCardRequest.Card = _card;
            return createCardRequest;
        }
    }
}
