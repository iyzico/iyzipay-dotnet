using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class LoyaltyInquiry : IyzipayResourceV2
	{
		public string Points { get; set; }
		public string Amount { get; set; }
		public string CardBank { get; set; }
		public string CardFamily { get; set; }
		public string Currency { get; set; }

		public static Task<LoyaltyInquiry> Create(LoyaltyInquiryRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/loyalty/inquire";
			return RestHttpClientV2.Create().PostAsync<LoyaltyInquiry>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
