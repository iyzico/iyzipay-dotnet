using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PeccoInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }
        public String RedirectUrl { get; set; }
        public String Token { get; set; }
        public long? TokenExpireTime { get; set; }

        private const string CreateUrl = "payment/pecco/initialize";
        public async static Task<PeccoInitialize> CreateAsync(CreatePeccoInitializeRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PeccoInitialize>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static PeccoInitialize Create(CreatePeccoInitializeRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PeccoInitialize>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
