﻿using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class SubMerchantC2C : IyzipayResource
    {
        public String TxId { get; set; }

        public static Task<SubMerchantC2C> Create(CreateC2CSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<SubMerchantC2C>(options.BaseUrl + "/onboarding/settlement-to-balance/submerchant", GetHttpHeaders(request, options), request);
        }
        public static Task<SubMerchantC2C> Verify(VerifyC2CSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<SubMerchantC2C>(options.BaseUrl + "/onboarding/settlement-to-balance/submerchant", GetHttpHeaders(request, options), request);
        }
    }
}