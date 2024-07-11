using Iyzipay.Request;

namespace Iyzipay.Model
{
	public class PayWithIyzicoInitialize : PayWithIyzicoInitializeResource
	{
		public static PayWithIyzicoInitialize Create(CreatePayWithIyzicoInitializeRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/pay-with-iyzico/initialize";
			return RestHttpClientV2.Create().Post<PayWithIyzicoInitialize>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
