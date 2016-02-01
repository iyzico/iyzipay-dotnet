using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ThreeDSAuth : ConnectPayment
    {
        public static Task<ThreeDSAuth> Create(CreateThreeDSAuthRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ThreeDSAuth>(options.BaseUrl + "/payment/iyzipos/auth3ds/ecom", request);
        }
    }
}
