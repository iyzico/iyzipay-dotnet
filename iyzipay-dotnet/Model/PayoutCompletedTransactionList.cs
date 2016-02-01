using Iyzipay.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class PayoutCompletedTransactionList : IyzipayResource
    {
        public List<PayoutCompletedTransaction> PayoutCompletedTransactions { get; set; }

        public static Task<PayoutCompletedTransactionList> Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<PayoutCompletedTransactionList>(options.BaseUrl + "/reporting/settlement/payoutcompleted", request);
        }
    }
}
