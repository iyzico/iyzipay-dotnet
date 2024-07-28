using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicPaymentPostAuth : BasicPaymentResource
    {        
        public static Task<BasicPaymentPostAuth> Create(CreatePaymentPostAuthRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/postauth/basic";
			return RestHttpClientV2.Create().PostAsync<BasicPaymentPostAuth>(options.BaseUrl + uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
    }
}
