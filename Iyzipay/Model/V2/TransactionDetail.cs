using Iyzipay.Request.V2;
using System;

namespace Iyzipay.Model.V2
{
    public class TransactionDetail : TransactionReportResource
    {
        public static TransactionDetail Retrieve(RetrieveTransactionDetailRequest request, Options options)
        {
            String url = options.BaseUrl
                + "/v2/reporting/payment/details?paymentConversationId="
                + request.PaymentConversationId;
            return RestHttpClientV2.Create().Get<TransactionDetail>(url, GetHttpHeadersWithUrlParams(request, url, options));
        }
    }
}
