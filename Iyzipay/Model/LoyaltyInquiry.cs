using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class LoyaltyInquiry : IyzipayResource
    {
        public string Points { get; set; }
        public string Amount { get; set; }
        public string CardBank { get; set; }
        public string CardFamily { get; set; }
        public string Currency { get; set; }

        public static Task<LoyaltyInquiry> Create(LoyaltyInquiryRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<LoyaltyInquiry>(options.BaseUrl + "/payment/loyalty/inquire", GetHttpHeaders(request, options), request);
        }
    }
}
