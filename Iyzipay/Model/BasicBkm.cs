using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class BasicBkm : BasicPaymentResource
	{
		public string Token { get; set; }
		public string CallbackUrl { get; set; }
		public string PaymentStatus { get; set; }

		public static Task<BasicBkm> Retrieve(RetrieveBkmRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/bkm/auth/detail/basic";
			return RestHttpClientV2.Create().PostAsync<BasicBkm>(options.BaseUrl + uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
