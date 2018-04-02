using Iyzipay.Request;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public sealed class RetrieveSubMerchantRequestBuilder : BaseRequestBuilder
    {
        private string _subMerchantExternalId;

        private RetrieveSubMerchantRequestBuilder()
        {
        }

        public static RetrieveSubMerchantRequestBuilder Create()
        {
            return new RetrieveSubMerchantRequestBuilder();
        }

        public RetrieveSubMerchantRequestBuilder SubMerchantExternalId(string subMerchantExternalId)
        {
            _subMerchantExternalId = subMerchantExternalId;
            return this;
        }

        public RetrieveSubMerchantRequest Build()
        {
            RetrieveSubMerchantRequest retrieveSubMerchantRequest = new RetrieveSubMerchantRequest();
            retrieveSubMerchantRequest.Locale = Locale;
            retrieveSubMerchantRequest.ConversationId = ConversationId;
            retrieveSubMerchantRequest.SubMerchantExternalId = _subMerchantExternalId;
            return retrieveSubMerchantRequest;
        }
    }
}
