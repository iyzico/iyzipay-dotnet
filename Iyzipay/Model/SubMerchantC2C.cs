using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class SubMerchantC2C : IyzipayResource
    {
        public String TxId { get; set; }

        public static SubMerchantC2C Create(CreateC2CSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create().Post<SubMerchantC2C>(options.BaseUrl + "/onboarding/settlement-to-balance/submerchant", GetHttpHeaders(request, options), request);
        }
        public static SubMerchantC2C Verify(VerifyC2CSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create().Post<SubMerchantC2C>(options.BaseUrl + "/onboarding/settlement-to-balance/submerchant", GetHttpHeaders(request, options), request);
        }
    }
}
