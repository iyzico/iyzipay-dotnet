using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class PaymentPostAuth : PaymentResource
	{
		public static Task<PaymentPostAuth> Create(CreatePaymentPostAuthRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/postauth";
			return RestHttpClientV2.Create().PostAsync<PaymentPostAuth>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
