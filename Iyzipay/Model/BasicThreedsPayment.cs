using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicThreedsPayment : BasicPaymentResource
    {
        public static Task<BasicThreedsPayment> Create(CreateThreedsPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<BasicThreedsPayment>(options.BaseUrl + "/payment/3dsecure/auth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
