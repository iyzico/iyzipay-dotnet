using Iyzipay.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PayoutCompletedTransactionList : IyzipayResource
    {
        public List<PayoutCompletedTransaction> PayoutCompletedTransactions { get; set; }

        public async static Task<PayoutCompletedTransactionList> RetrieveAsync(RetrieveTransactionsRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PayoutCompletedTransactionList>("reporting/settlement/payoutcompleted", GetHttpHeaders(request, options), request);
        }

        public static PayoutCompletedTransactionList Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PayoutCompletedTransactionList>("reporting/settlement/payoutcompleted", GetHttpHeaders(request, options), request);
        }
    }
}
