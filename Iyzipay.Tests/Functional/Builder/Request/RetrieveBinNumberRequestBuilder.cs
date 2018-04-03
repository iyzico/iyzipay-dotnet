using Iyzipay.Request;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public sealed class RetrieveBinNumberRequestBuilder : BaseRequestBuilder
    {
        private string _binNumber;

        private RetrieveBinNumberRequestBuilder()
        {
        }

        public static RetrieveBinNumberRequestBuilder Create()
        {
            return new RetrieveBinNumberRequestBuilder();
        }

        public RetrieveBinNumberRequestBuilder BinNumber(string binNumber)
        {
            this._binNumber = binNumber;
            return this;
        }

        public RetrieveBinNumberRequest Build()
        {
            RetrieveBinNumberRequest retrieveBinNumberRequest = new RetrieveBinNumberRequest();
            retrieveBinNumberRequest.Locale = Locale;
            retrieveBinNumberRequest.ConversationId = ConversationId;
            retrieveBinNumberRequest.BinNumber = _binNumber;
            return retrieveBinNumberRequest;
        }
    }
}
