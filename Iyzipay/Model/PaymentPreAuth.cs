using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PaymentPreAuth : PaymentResource
    {
        public static Task<PaymentPreAuth> Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<PaymentPreAuth>(options.BaseUrl + "/payment/preauth", GetHttpHeaders(request, options), request);
        }

        public static Task<PaymentPreAuth> Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<PaymentPreAuth>(options.BaseUrl + "/payment/detail", GetHttpHeaders(request, options), request);
        }
    }
}
