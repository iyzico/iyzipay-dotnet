using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectPaymentAuth : ConnectPayment
    {
        public static ConnectPaymentAuth Create(CreateConnectPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ConnectPaymentAuth>(options.BaseUrl + "/payment/iyziconnect/auth", GetHttpHeaders(request, options), request);
        }
    }
}
