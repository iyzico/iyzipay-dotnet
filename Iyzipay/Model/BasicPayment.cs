using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class BasicPayment : BasicPaymentResource
	{
		public static Task<BasicPayment> Create(CreateBasicPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/auth/basic";
			return RestHttpClientV2.Create().PostAsync<BasicPayment>(options.BaseUrl + uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
