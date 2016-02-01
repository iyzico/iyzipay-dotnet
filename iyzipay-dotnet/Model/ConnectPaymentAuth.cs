using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectPaymentAuth : ConnectPayment
    {
        public static Task<ConnectPaymentAuth> Create(CreateConnectPaymentRequest request, Options options)
        {
            return new RestHttpClient().Post<ConnectPaymentAuth>(options.BaseUrl + "/payment/iyziconnect/auth", GetHttpHeaders(request, options), request);
        }
    }
}
