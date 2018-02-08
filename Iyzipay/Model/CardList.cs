using Iyzipay.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CardList : IyzipayResource
    {
        public String CardUserKey { get; set; }
        public List<Card> CardDetails { get; set; }

        private const string RetrieveUrl = "cardstorage/cards";
        public async static Task<CardList> RetrieveAsync(RetrieveCardListRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CardList>(RetrieveUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static CardList Retrieve(RetrieveCardListRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CardList>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
