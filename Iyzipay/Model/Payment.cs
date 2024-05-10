using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Payment : PaymentResource
    {
        public static Task<Payment> Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<Payment>(options.BaseUrl + "/payment/auth", GetHttpHeaders(request, options), request);
        }

        public static Task<Payment> Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<Payment>(options.BaseUrl + "/payment/detail", GetHttpHeaders(request, options), request);
        }
    }
}
