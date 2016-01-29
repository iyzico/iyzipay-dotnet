using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectPaymentAuth : ConnectPayment
    {
        public static Task<ConnectPaymentAuth> Create(CreateConnectPaymentRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ConnectPaymentAuth>(options.BaseUrl + "/payment/iyziconnect/auth", request);
        }
    }
}
