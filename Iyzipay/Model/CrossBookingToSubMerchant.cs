using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CrossBookingToSubMerchant : IyzipayResource
    {
        public static Task<CrossBookingToSubMerchant> Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<CrossBookingToSubMerchant>(options.BaseUrl + "/crossbooking/send", GetHttpHeaders(request, options), request);
        }
    }
}
