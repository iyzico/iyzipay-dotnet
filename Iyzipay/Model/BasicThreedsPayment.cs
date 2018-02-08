using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicThreedsPayment : BasicPaymentResource
    {
        private const string CreateUrl = "payment/3dsecure/auth/basic";
        public async static Task<BasicThreedsPayment> CreateAsync(CreateThreedsPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<BasicThreedsPayment>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static BasicThreedsPayment Create(CreateThreedsPaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<BasicThreedsPayment>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
