using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicPaymentPreAuth : BasicPaymentResource
    {
        public static Task<BasicPaymentPreAuth> Create(CreateBasicPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<BasicPaymentPreAuth>(options.BaseUrl + "/payment/preauth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
