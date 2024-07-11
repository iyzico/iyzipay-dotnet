using Iyzipay.Request;

namespace Iyzipay.Model
{
	public class PaymentPreAuth : PaymentResource
	{
		public static PaymentPreAuth Create(CreatePaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/preauth";
			return RestHttpClientV2.Create().Post<PaymentPreAuth>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}

		public static PaymentPreAuth Retrieve(RetrievePaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/detail";
			return RestHttpClientV2.Create().Post<PaymentPreAuth>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
