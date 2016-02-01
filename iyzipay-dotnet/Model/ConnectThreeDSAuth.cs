using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectThreeDSAuth : ConnectPayment
    {
        public static Task<ConnectThreeDSAuth> Create(CreateConnectThreeDSAuthRequest request, Options options)
        {
            return new RestHttpClient().Post<ConnectThreeDSAuth>(options.BaseUrl + "/payment/iyziconnect/auth3ds", GetHttpHeaders(request, options), request);
        }
    }
}
