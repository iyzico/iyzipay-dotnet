using Iyzipay.Request;

namespace Iyzipay.Model
{
	public class PaymentPostAuth : PaymentResource
	{
		public static PaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/postauth";
			return RestHttpClientV2.Create().Post<PaymentPostAuth>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
