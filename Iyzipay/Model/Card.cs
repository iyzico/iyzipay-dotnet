using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Card : IyzipayResourceV2
    {
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public string CardAlias { get; set; }
        public string BinNumber { get; set; }
        public string LastFourDigits { get; set; }
        public string CardType { get; set; }
        public string CardAssociation { get; set; }
        public string CardFamily { get; set; }
        public long? CardBankCode { get; set; }
        public string CardBankName { get; set; }

        public static Task<Card> Create(CreateCardRequest request, Options options)
        {
            var uri = options.BaseUrl + "/cardstorage/card";
            return RestHttpClientV2.Create().PostAsync<Card>(uri, GetHttpHeadersWithRequestBody(request,uri, options), request);
        }

        public static Task<Card> Delete(DeleteCardRequest request, Options options)
        {
            var uri = options.BaseUrl + "/cardstorage/card";
            return RestHttpClientV2.Create().DeleteAsync<Card>(uri, GetHttpHeadersWithRequestBody(request,uri, options), request);
        }
    }
}
