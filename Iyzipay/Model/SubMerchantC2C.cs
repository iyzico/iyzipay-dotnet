using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class SubMerchantC2C : IyzipayResourceV2
    {
        public string TxId { get; set; }

        public static Task<SubMerchantC2C> Create(CreateC2CSubMerchantRequest request, Options options)
        {
            var uri = options.BaseUrl + "/onboarding/settlement-to-balance/submerchant";
            return RestHttpClientV2.Create().PostAsync<SubMerchantC2C>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
        }
        public static Task<SubMerchantC2C> Verify(VerifyC2CSubMerchantRequest request, Options options)
        {
            var uri = options.BaseUrl + "/onboarding/settlement-to-balance/submerchant";
            return RestHttpClientV2.Create().PostAsync<SubMerchantC2C>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
        }
    }
}
