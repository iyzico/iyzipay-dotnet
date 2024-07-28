using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class PayWithIyzicoInitialize : PayWithIyzicoInitializeResource
	{
		public static Task<PayWithIyzicoInitialize> Create(CreatePayWithIyzicoInitializeRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/pay-with-iyzico/initialize";
			return RestHttpClientV2.Create().PostAsync<PayWithIyzicoInitialize>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
