using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
     class BinNumber : IyzipayResource
    {
        public String Bin { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardFamily { get; set; }
        public String BankName { get; set; }
        public long BankCode { get; set; }

        public static Task<BinNumber> Retrieve(RetrieveBinNumberRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<BinNumber>(options.BaseUrl + "/payment/bin/check", request);
        }
    }
}
