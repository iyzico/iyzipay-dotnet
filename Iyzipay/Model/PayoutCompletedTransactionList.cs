using Iyzipay.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PayoutCompletedTransactionList : IyzipayResourceV2
    {
        public List<PayoutCompletedTransaction> PayoutCompletedTransactions { get; set; }

        public static Task<PayoutCompletedTransactionList> Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            var uri = options.BaseUrl + "/reporting/settlement/payoutcompleted";
            return RestHttpClientV2.Create().PostAsync<PayoutCompletedTransactionList>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
        }
    }
}
