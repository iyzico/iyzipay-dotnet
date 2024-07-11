using Iyzipay.Request;

namespace Iyzipay.Model
{
	public class ThreedsPayment : PaymentResource
	{
		public static ThreedsPayment Create(CreateThreedsPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/3dsecure/auth";
			return RestHttpClientV2.Create().Post<ThreedsPayment>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}

		public static ThreedsPayment Retrieve(RetrievePaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/detail";
			return RestHttpClientV2.Create().Post<ThreedsPayment>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
