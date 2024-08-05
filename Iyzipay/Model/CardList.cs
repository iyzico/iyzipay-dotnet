using Iyzipay.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CardList : IyzipayResourceV2
    {
        public string CardUserKey { get; set; }
        public List<Card> CardDetails { get; set; }

        public static Task<CardList> Retrieve(RetrieveCardListRequest request, Options options)
        {
            var uri = options.BaseUrl + "/cardstorage/cards";
            return RestHttpClientV2.Create().PostAsync<CardList>(uri, GetHttpHeaders(request, uri, options), request);
        }
    }
}
