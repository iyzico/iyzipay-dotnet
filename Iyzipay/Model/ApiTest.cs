using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class ApiTest : IyzipayResource
    {
        private const string RetrieveUrl = "payment/test";

        public async static Task<IyzipayResource> RetrieveAsync(Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).GetAsync<IyzipayResource>(RetrieveUrl).ConfigureAwait(false);
        }

        public static IyzipayResource Retrieve(Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Get<IyzipayResource>(RetrieveUrl);
        }
    }
}
