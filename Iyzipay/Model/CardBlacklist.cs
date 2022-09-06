using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class CardBlacklist : IyzipayResource
    {
        public String CardUserKey { get; set; }
        public String CardToken { get; set; }
        public String CardNumber { get; set; }
        public Boolean Blacklisted { get; set; }
        public static CardBlacklist Create(CreateCardBlacklistRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CardBlacklist>(options.BaseUrl + "/cardstorage/blacklist/card", GetHttpHeaders(request, options), request);
        }

        public static CardBlacklist Update(UpdateCardBlacklistRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CardBlacklist>(options.BaseUrl + "/cardstorage/blacklist/card/inactive", GetHttpHeaders(request, options), request);
        }

        public static CardBlacklist Retrieve(RetrieveCardBlacklistRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CardBlacklist>(options.BaseUrl + "/cardstorage/blacklist/card/retrieve", GetHttpHeaders(request, options), request);
        }
    }
}
