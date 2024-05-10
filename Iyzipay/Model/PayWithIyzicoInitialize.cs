using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PayWithIyzicoInitialize : PayWithIyzicoInitializeResource
    {
        public static Task<PayWithIyzicoInitialize> Create(CreatePayWithIyzicoInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<PayWithIyzicoInitialize>(options.BaseUrl + "/payment/pay-with-iyzico/initialize", GetHttpHeaders(request, options), request);
        }
    }
}
