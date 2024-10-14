using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class BasicPaymentPreAuth : BasicPaymentResource
	{
		public static Task<BasicPaymentPreAuth> Create(CreateBasicPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/preauth/basic";
			return RestHttpClientV2.Create().PostAsync<BasicPaymentPreAuth>(options.BaseUrl + uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
