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

        public async static Task<CardList> RetrieveAsync(RetrieveCardListRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CardList>("cardstorage/cards", GetHttpHeaders(request, options), request);
        }

        public static CardList Retrieve(RetrieveCardListRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CardList>("cardstorage/cards", GetHttpHeaders(request, options), request);
        }
    }
}
