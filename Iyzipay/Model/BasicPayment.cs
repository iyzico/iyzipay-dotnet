using Iyzipay.Request;

namespace Iyzipay.Model
{
	public class BasicPayment : BasicPaymentResource
	{
		public static BasicPayment Create(CreateBasicPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/auth/basic";
			return RestHttpClientV2.Create().Post<BasicPayment>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
