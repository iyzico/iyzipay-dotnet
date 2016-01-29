using Iyzipay.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class CardList : IyzipayResource
    {
        public String cardUserKey { get; set; }
        public List<Card> cardDetails { get; set; }

        public static Task<CardList> Create(RetrieveCardListRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<CardList>(options.BaseUrl + "/cardstorage/cards", request);
        }
    }
}
