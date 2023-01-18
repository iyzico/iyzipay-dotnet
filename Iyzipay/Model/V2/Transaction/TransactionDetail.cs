﻿using System;
using Iyzipay.Request.V2;

namespace Iyzipay.Model.V2.Transaction
{
    public class TransactionDetail : TransactionDetailResource
    {
        public static TransactionDetail Retrieve(RetrieveTransactionDetailRequest request, Options options)
        {
            String url;
            if (String.IsNullOrEmpty(request.PaymentId))
            {
                url = options.BaseUrl
                + "/v2/reporting/payment/details?paymentConversationId="
                + request.PaymentConversationId;
            }
            else
            {
                url = options.BaseUrl
                + "/v2/reporting/payment/details?paymentId="
                + request.PaymentId;
            }
            return RestHttpClientV2.Create().Get<TransactionDetail>(url, GetHttpHeadersWithUrlParams(request, url, options));
        }
    }
}
