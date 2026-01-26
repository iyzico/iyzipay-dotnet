using System.Collections.Generic;
using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class CardManagementPageCard : IyzipayResourceV2
    {
        private string ExternalId { get; set; }
        private string CardUserKey { get; set; }
        private List<Card> CardDetails { get; set; }

        public static CardManagementPageCard Retrieve(RetrieveCardManagementPageCardRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v1/card-management/pages/{request.PageToken}/cards?locale={request.Locale}&conversationId={request.ConversationId}";
            return RestHttpClient.Create().Post<CardManagementPageCard>(uri, GetHttpHeadersWithUrlParams(request, uri, options));
        }
    }
}