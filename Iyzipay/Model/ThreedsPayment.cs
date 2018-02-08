using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class ThreedsPayment : PaymentResource
    {
        private const string CreateUrl = "payment/3dsecure/auth";
        private const string RetrieveUrl = "payment/detail";
        public static ThreedsPayment Create(CreateThreedsPaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<ThreedsPayment>(CreateUrl, GetHttpHeaders(request, options), request);
        }

        public static ThreedsPayment Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<ThreedsPayment>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }



        public async static Task<ThreedsPayment> CreateAsync(CreateThreedsPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<ThreedsPayment>(CreateUrl, GetHttpHeaders(request, options), request);
        }

        public async static Task<ThreedsPayment> RetrieveAsync(RetrievePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<ThreedsPayment>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
