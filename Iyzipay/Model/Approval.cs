﻿using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Approval : IyzipayResource
    {
        public String PaymentTransactionId { get; set; }

        public static Task<Approval> Create(CreateApprovalRequest request, Options options)
        {
            return  RestHttpClient.Create().PostAsync<Approval>(options.BaseUrl + "/payment/iyzipos/item/approve", GetHttpHeaders(request, options), request);
        }
    }
}
