using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class ThreedsPayment : PaymentResource
	{
		public static Task<ThreedsPayment> Create(CreateThreedsPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/3dsecure/auth";
			return RestHttpClientV2.Create().PostAsync<ThreedsPayment>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}

		public static Task<ThreedsPayment> Retrieve(RetrievePaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/detail";
			return RestHttpClientV2.Create().PostAsync<ThreedsPayment>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
