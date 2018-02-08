using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicThreedsPayment : BasicPaymentResource
    {
        public async static Task<BasicThreedsPayment> CreateAsync(CreateThreedsPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<BasicThreedsPayment>("payment/3dsecure/auth/basic", GetHttpHeaders(request, options), request);
        }

        public static BasicThreedsPayment Create(CreateThreedsPaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<BasicThreedsPayment>("payment/3dsecure/auth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
