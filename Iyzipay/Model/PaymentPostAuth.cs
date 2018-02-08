using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PaymentPostAuth : PaymentResource
    {
        private const string CreateUrl = "payment/postauth";
        public async static Task<PaymentPostAuth> CreateAsync(CreatePaymentPostAuthRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PaymentPostAuth>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static PaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PaymentPostAuth>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
