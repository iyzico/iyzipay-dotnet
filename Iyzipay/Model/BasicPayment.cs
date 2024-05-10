using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicPayment : BasicPaymentResource
    {
        public static Task<BasicPayment> Create(CreateBasicPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<BasicPayment>(options.BaseUrl + "/payment/auth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
