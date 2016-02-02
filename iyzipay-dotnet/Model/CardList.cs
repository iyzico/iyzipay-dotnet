using Iyzipay.Request;
using System;
using System.Collections.Generic;

namespace Iyzipay.Model
{
    public class CardList : IyzipayResource
    {
        public String cardUserKey { get; set; }
        public List<Card> cardDetails { get; set; }

        public static CardList Retrieve(RetrieveCardListRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CardList>(options.BaseUrl + "/cardstorage/cards", GetHttpHeaders(request, options), request);
        }
    }
}
