using Iyzipay.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PayoutCompletedTransactionList : IyzipayResource
    {
        public List<PayoutCompletedTransaction> PayoutCompletedTransactions { get; set; }
        private const string RetrieveUrl = "reporting/settlement/payoutcompleted";
        public async static Task<PayoutCompletedTransactionList> RetrieveAsync(RetrieveTransactionsRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PayoutCompletedTransactionList>(RetrieveUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static PayoutCompletedTransactionList Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PayoutCompletedTransactionList>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
