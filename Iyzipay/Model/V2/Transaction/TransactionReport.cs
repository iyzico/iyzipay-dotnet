using System;
using Iyzipay.Request.V2;

namespace Iyzipay.Model.V2.Transaction
{
    public class TransactionReport : TransactionReportResource
    {
        public static TransactionReport Retrieve(RetrieveTransactionReportRequest request, Options options)
        {
            String url = options.BaseUrl
                + "/v2/reporting/payment/transactions?transactionDate="
                + request.TransactionDate
                + "&page="
                + request.Page;
            return RestHttpClientV2.Create().Get<TransactionReport>(url, GetHttpHeadersWithUrlParams(request, url, options));
        }
    }
}
