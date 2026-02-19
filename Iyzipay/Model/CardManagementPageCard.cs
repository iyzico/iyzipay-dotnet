using System.Collections.Generic;
using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class CardManagementPageCard : IyzipayResourceV2
    {
        public string ExternalId { get; set; }
        public string CardUserKey { get; set; }
        public List<Card> CardDetails { get; set; }

        public static CardManagementPageCard Retrieve(RetrieveCardManagementPageCardRequest request, Options options)
        {
            var uri = $"{options.BaseUrl}/v1/card-management/pages/{request.PageToken}/cards?locale={request.Locale}&conversationId={request.ConversationId}";
            return RestHttpClientV2.Create().Post<CardManagementPageCard>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
        }
    }
}
