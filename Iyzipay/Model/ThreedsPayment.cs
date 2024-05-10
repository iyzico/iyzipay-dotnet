using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class ThreedsPayment : PaymentResource
    {
        public static Task<ThreedsPayment> Create(CreateThreedsPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<ThreedsPayment>(options.BaseUrl + "/payment/3dsecure/auth", GetHttpHeaders(request, options), request);
        }

        public static Task<ThreedsPayment> Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<ThreedsPayment>(options.BaseUrl + "/payment/detail", GetHttpHeaders(request, options), request);
        }
    }
}
