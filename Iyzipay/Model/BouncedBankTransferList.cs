using System.Collections.Generic;
using Newtonsoft.Json;
using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BouncedBankTransferList : IyzipayResource
    {
        [JsonProperty(PropertyName = "bouncedRows")]
        public List<BankTransfer> BankTransfers { get; set; }

        public async static Task<BouncedBankTransferList> RetrieveAsync(RetrieveTransactionsRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<BouncedBankTransferList>("reporting/settlement/bounced", GetHttpHeaders(request, options), request);
        }

        public static BouncedBankTransferList Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<BouncedBankTransferList>("reporting/settlement/bounced", GetHttpHeaders(request, options), request);
        }
    }
}
