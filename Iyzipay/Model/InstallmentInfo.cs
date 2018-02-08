using Iyzipay.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class InstallmentInfo : IyzipayResource
    {
        public List<InstallmentDetail> InstallmentDetails { get; set; }

        private const string RetrieveUrl = "payment/iyzipos/installment";
        public async static Task<InstallmentInfo> RetrieveAsync(RetrieveInstallmentInfoRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<InstallmentInfo>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }

        public static InstallmentInfo Retrieve(RetrieveInstallmentInfoRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<InstallmentInfo>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
