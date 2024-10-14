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

        public static TransactionReport Retrieve(RetrieveScrollTransactionReportRequest request, Options options)
        {
			string uri = $"{options.BaseUrl}/v2/reporting/payment/scroll-transactions{GetQueryParams(request)}";
            return RestHttpClientV2.Create().Get<TransactionReport>(uri, GetHttpHeadersWithUrlParams(request, uri, options));
        }
		private static string GetQueryParams(RetrieveScrollTransactionReportRequest request)
		{
			if (request == null)
			{
				return "";
			}

			string queryParams = "?conversationId=" + request.ConversationId;

			if (!String.IsNullOrEmpty(request.Locale))
			{
				queryParams += "&locale=" + request.Locale;
			}

			if (!String.IsNullOrEmpty(request.DocumentScrollVoSortingOrder))
			{
				queryParams += "&documentScrollVoSortingOrder=" + request.DocumentScrollVoSortingOrder;
			}

			if (!String.IsNullOrEmpty(request.TransactionDate))
			{
				queryParams += "&transactionDate=" + request.TransactionDate;
			}

			if (request.LastId.HasValue)
			{
				queryParams += "&lastId=" + request.LastId;
			}

			return queryParams;
		}
	}
}
