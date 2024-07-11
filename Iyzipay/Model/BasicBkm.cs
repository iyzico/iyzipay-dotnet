using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
	public class BasicBkm : BasicPaymentResource
	{
		public string Token { get; set; }
		public string CallbackUrl { get; set; }
		public string PaymentStatus { get; set; }

		public static BasicBkm Retrieve(RetrieveBkmRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/bkm/auth/detail/basic";
			return RestHttpClientV2.Create().Post<BasicBkm>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
