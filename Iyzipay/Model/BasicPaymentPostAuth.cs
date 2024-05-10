using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicPaymentPostAuth : BasicPaymentResource
    {        
        public static Task<BasicPaymentPostAuth> Create(CreatePaymentPostAuthRequest request, Options options)
		{
			return RestHttpClient.Create().PostAsync<BasicPaymentPostAuth>(options.BaseUrl + "/payment/postauth/basic", GetHttpHeaders(request, options), request);
		}
    }
}
