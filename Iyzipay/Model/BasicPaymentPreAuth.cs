using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicPaymentPreAuth : BasicPaymentResource
    {
        public async static Task<BasicPaymentPreAuth> CreateAsync(CreateBasicPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<BasicPaymentPreAuth>("payment/preauth/basic", GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static BasicPaymentPreAuth Create(CreateBasicPaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<BasicPaymentPreAuth>("payment/preauth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
