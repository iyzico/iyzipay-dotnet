using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class ConnectPaymentPreAuth : ConnectPayment
    {
        public static ConnectPaymentPreAuth Create(CreateConnectPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectPaymentPreAuth>(options.BaseUrl + "/payment/iyziconnect/preauth", GetHttpHeaders(request, options), request);
        }
    }
}
