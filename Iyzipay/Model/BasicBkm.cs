﻿using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicBkm : BasicPaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }
        public String PaymentStatus { get; set; }

        public static Task<BasicBkm> Retrieve(RetrieveBkmRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<BasicBkm>(options.BaseUrl + "/payment/bkm/auth/detail/basic", GetHttpHeaders(request, options), request);
        }
    }
}
