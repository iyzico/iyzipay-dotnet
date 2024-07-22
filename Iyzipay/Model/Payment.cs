using Iyzipay.Request;

namespace Iyzipay.Model
{
	public class Payment : PaymentResource
	{
		public static Payment Create(CreatePaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/auth";
			return RestHttpClientV2.Create().Post<Payment>(options.BaseUrl + "/payment/auth", GetHttpHeadersWithRequestBody(request, uri, options), request);
		}

		public static Payment Retrieve(RetrievePaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/detail";
			return RestHttpClientV2.Create().Post<Payment>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
