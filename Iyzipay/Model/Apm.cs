using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Apm : ApmResource
    {
        private const string CreateUrl = "payment/apm/initialize";
        private const string RetrieveUrl = "payment/apm/retrieve";
        public async static Task<Apm> CreateAsync(CreateApmInitializeRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Apm>(CreateUrl, GetHttpHeaders(request, options), request);
        }

        public async static Task<Apm> RetrieveAsync(RetrieveApmRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Apm>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }

        public static Apm Create(CreateApmInitializeRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Apm>(CreateUrl, GetHttpHeaders(request, options), request);
        }

        public static Apm Retrieve(RetrieveApmRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Apm>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
