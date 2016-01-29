using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectThreeDSAuth : ConnectPayment
    {
        public static Task<ConnectThreeDSAuth> Create(CreateConnectThreeDSAuthRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ConnectThreeDSAuth>(options.BaseUrl + "/payment/iyziconnect/auth3ds", request);
        }
    }
}
