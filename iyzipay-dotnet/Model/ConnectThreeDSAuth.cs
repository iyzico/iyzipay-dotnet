using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class ConnectThreeDSAuth : ConnectPayment
    {
        public static ConnectThreeDSAuth Create(CreateConnectThreeDSAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectThreeDSAuth>(options.BaseUrl + "/payment/iyziconnect/auth3ds", GetHttpHeaders(request, options), request);
        }
    }
}
