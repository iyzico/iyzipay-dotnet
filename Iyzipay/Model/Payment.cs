using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class Payment : PaymentResource
	{
		public static Task<Payment> Create(CreatePaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/auth";
			return RestHttpClientV2.Create().PostAsync<Payment>(options.BaseUrl + "/payment/auth", GetHttpHeadersWithRequestBody(request, uri, options), request);
		}

		public static Task<Payment> Retrieve(RetrievePaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/detail";
			return RestHttpClientV2.Create().PostAsync<Payment>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
