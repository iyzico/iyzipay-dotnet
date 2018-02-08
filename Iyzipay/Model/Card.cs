using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Card : IyzipayResource
    {
        public String ExternalId { get; set; }
        public String Email { get; set; }
        public String CardUserKey { get; set; }
        public String CardToken { get; set; }
        public String CardAlias { get; set; }
        public String BinNumber { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardFamily { get; set; }
        public long? CardBankCode { get; set; }
        public String CardBankName { get; set; }

        public async static Task<Card> CreateAsync(CreateCardRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Card>("cardstorage/card", GetHttpHeaders(request, options), request);
        }

        public async static Task<Card> DeleteAsync(DeleteCardRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).DeleteAsync<Card>("cardstorage/card", GetHttpHeaders(request, options), request);
        }

        public static Card Create(CreateCardRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Card>("cardstorage/card", GetHttpHeaders(request, options), request);
        }

        public static Card Delete(DeleteCardRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Delete<Card>("cardstorage/card", GetHttpHeaders(request, options), request);
        }
    }
}
