using Iyzipay.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class PayoutCompletedTransactionList : IyzipayResource
    {
        public List<PayoutCompletedTransaction> PayoutCompletedTransactions { get; set; }

        public static PayoutCompletedTransactionList Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PayoutCompletedTransactionList>(options.BaseUrl + "/reporting/settlement/payoutcompleted", GetHttpHeaders(request, options), request);
        }
    }
}
