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
        public String LastFourDigits { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardFamily { get; set; }
        public long? CardBankCode { get; set; }
        public String CardBankName { get; set; }

        public static Task<Card> Create(CreateCardRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<Card>(options.BaseUrl + "/cardstorage/card", GetHttpHeaders(request, options), request);
        }

        public static Task<Card> Delete(DeleteCardRequest request, Options options)
        {
            return RestHttpClient.Create().DeleteAsync<Card>(options.BaseUrl + "/cardstorage/card", GetHttpHeaders(request, options), request);
        }
    }
}
