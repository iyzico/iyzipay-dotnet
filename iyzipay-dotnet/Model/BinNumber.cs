using Iyzipay.Request;
using Newtonsoft.Json;
using System;

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

        public static BinNumber Retrieve(RetrieveBinNumberRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BinNumber>(options.BaseUrl + "/payment/bin/check", GetHttpHeaders(request, options), request);
        }
    }
}
