using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class BasicThreedsPayment : BasicPaymentResource
	{
		public static Task<BasicThreedsPayment> Create(CreateThreedsPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/3dsecure/auth/basic";

			return RestHttpClientV2.Create().PostAsync<BasicThreedsPayment>(options.BaseUrl + uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
