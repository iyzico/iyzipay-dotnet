using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicPaymentPostAuth : BasicPaymentResource
    {
        private const string CreateUrl = "payment/postauth/basic";
        public async static Task<BasicPaymentPostAuth> CreateAsync(CreatePaymentPostAuthRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<BasicPaymentPostAuth>(CreateUrl, GetHttpHeaders(request, options), request);
        }

        public static BasicPaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<BasicPaymentPostAuth>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
