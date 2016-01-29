using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Iyzipay.Request;

namespace Iyzipay.Model
{
    class BouncedBankTransferList : IyzipayResource
    {
        [JsonProperty(PropertyName = "bouncedRows")]
        public List<BankTransfer> BankTransfers { get; set; }

        public static Task<BouncedBankTransferList> Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<BouncedBankTransferList>(options.BaseUrl + "/reporting/settlement/bounced", request);
        }
    }
}
