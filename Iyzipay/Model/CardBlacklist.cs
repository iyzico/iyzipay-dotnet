using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CardBlacklist : IyzipayResource
    {
        public String CardUserKey { get; set; }
        public String CardToken { get; set; }
        public String CardNumber { get; set; }
        public Boolean Blacklisted { get; set; }
        public static Task<CardBlacklist> Create(CreateCardBlacklistRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<CardBlacklist>(options.BaseUrl + "/cardstorage/blacklist/card", GetHttpHeaders(request, options), request);
        }

        public static Task<CardBlacklist> Update(UpdateCardBlacklistRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<CardBlacklist>(options.BaseUrl + "/cardstorage/blacklist/card/inactive", GetHttpHeaders(request, options), request);
        }

        public static Task<CardBlacklist> Retrieve(RetrieveCardBlacklistRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<CardBlacklist>(options.BaseUrl + "/cardstorage/blacklist/card/retrieve", GetHttpHeaders(request, options), request);
        }
    }
}
