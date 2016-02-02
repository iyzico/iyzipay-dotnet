using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class ConnectPaymentAuth : ConnectPayment
    {
        public static ConnectPaymentAuth Create(CreateConnectPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectPaymentAuth>(options.BaseUrl + "/payment/iyziconnect/auth", GetHttpHeaders(request, options), request);
        }
    }
}
