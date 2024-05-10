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

        public static Task<CardList> Retrieve(RetrieveCardListRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<CardList>(options.BaseUrl + "/cardstorage/cards", GetHttpHeaders(request, options), request);
        }
    }
}
