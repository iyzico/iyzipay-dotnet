using Iyzipay.Request;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public class CreatePeccoPaymentRequestBuilder : BaseRequestBuilder
    {
        private string _token;

        private CreatePeccoPaymentRequestBuilder()
        {
        }

        public static CreatePeccoPaymentRequestBuilder Create()
        {
            return new CreatePeccoPaymentRequestBuilder();
        }

        public CreatePeccoPaymentRequestBuilder Token(string token)
        {
            _token = token;
            return this;
        }

        public CreatePeccoPaymentRequest Build()
        {
            CreatePeccoPaymentRequest createPeccoPaymentRequest = new CreatePeccoPaymentRequest();
            createPeccoPaymentRequest.Token = _token;
            return createPeccoPaymentRequest;
        }
    }
}
