using Iyzipay.Request;

namespace Iyzipay.Model
{
	public class BasicThreedsPayment : BasicPaymentResource
	{
		public static BasicThreedsPayment Create(CreateThreedsPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/3dsecure/auth/basic";
			return RestHttpClientV2.Create().Post<BasicThreedsPayment>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
