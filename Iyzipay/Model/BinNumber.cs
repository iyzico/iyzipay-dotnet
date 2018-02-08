using Iyzipay.Request;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BinNumber : IyzipayResource
    {
        [JsonProperty(PropertyName = "binNumber")]
        public String Bin { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardFamily { get; set; }
        public String BankName { get; set; }
        public long BankCode { get; set; }

        private const string RetrieveUrl = "payment/bin/check";
        public async static Task<BinNumber> RetrieveAsync(RetrieveBinNumberRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<BinNumber>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }

        public static BinNumber Retrieve(RetrieveBinNumberRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<BinNumber>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
