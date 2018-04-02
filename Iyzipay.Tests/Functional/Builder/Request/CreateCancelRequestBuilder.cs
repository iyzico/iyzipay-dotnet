using Iyzipay.Request;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public sealed class CreateCancelRequestBuilder
    {
        private string _paymentId;
        private string _ip = "85.34.78.112";

        private CreateCancelRequestBuilder()
        {
        }

        public static CreateCancelRequestBuilder Create()
        {
            return new CreateCancelRequestBuilder();
        }

        public CreateCancelRequestBuilder PaymentId(string paymentId)
        {
            _paymentId = paymentId;
            return this;
        }

        public CreateCancelRequestBuilder Ip(string ip)
        {
            _ip = ip;
            return this;
        }

        public CreateCancelRequest Build()
        {
            CreateCancelRequest cancelRequest = new CreateCancelRequest();
            cancelRequest.PaymentId = _paymentId;
            cancelRequest.Ip = _ip;
            return cancelRequest;
        }
    }
}
