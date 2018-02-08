using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicPayment : BasicPaymentResource
    {
        private const string CerateUrl = "payment/auth/basic";
        public async static Task<BasicPayment> CreateAsync(CreateBasicPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<BasicPayment>(CerateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static BasicPayment Create(CreateBasicPaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<BasicPayment>(CerateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
