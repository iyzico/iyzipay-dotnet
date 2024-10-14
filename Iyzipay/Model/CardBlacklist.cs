using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CardBlacklist : IyzipayResourceV2
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public string CardNumber { get; set; }
        public bool Blacklisted { get; set; }
        public static Task<CardBlacklist> Create(CreateCardBlacklistRequest request, Options options)
		{
			var uri = options.BaseUrl + "/cardstorage/blacklist/card";
			return RestHttpClientV2.Create().PostAsync<CardBlacklist>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
        }

        public static Task<CardBlacklist> Update(UpdateCardBlacklistRequest request, Options options)
        {
            var uri = options.BaseUrl + "/cardstorage/blacklist/card/inactive";
            return RestHttpClientV2.Create().PostAsync<CardBlacklist>(uri, GetHttpHeadersWithRequestBody(request, uri,options), request);
        }

        public static Task<CardBlacklist> Retrieve(RetrieveCardBlacklistRequest request, Options options)
        {
            var uri = options.BaseUrl + "/cardstorage/blacklist/card/retrieve";
            return RestHttpClientV2.Create().PostAsync<CardBlacklist>(uri, GetHttpHeadersWithRequestBody(request, uri,options), request);
        }
    }
}
