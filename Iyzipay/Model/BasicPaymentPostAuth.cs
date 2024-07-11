using Iyzipay.Request;

namespace Iyzipay.Model
{
	public class BasicPaymentPostAuth : BasicPaymentResource
	{
		public static BasicPaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/postauth/basic";
			return RestHttpClientV2.Create().Post<BasicPaymentPostAuth>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
