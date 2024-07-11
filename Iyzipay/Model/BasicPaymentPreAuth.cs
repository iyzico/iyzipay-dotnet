using Iyzipay.Request;

namespace Iyzipay.Model
{
	public class BasicPaymentPreAuth : BasicPaymentResource
	{
		public static BasicPaymentPreAuth Create(CreateBasicPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/preauth/basic";
			return RestHttpClientV2.Create().Post<BasicPaymentPreAuth>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
