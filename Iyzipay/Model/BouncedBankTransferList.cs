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

        private const string RetrieveUrl = "reporting/settlement/bounced";
        public async static Task<BouncedBankTransferList> RetrieveAsync(RetrieveTransactionsRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<BouncedBankTransferList>(RetrieveUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static BouncedBankTransferList Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<BouncedBankTransferList>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
