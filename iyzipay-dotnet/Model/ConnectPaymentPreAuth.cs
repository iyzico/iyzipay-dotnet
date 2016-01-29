using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectPaymentPreAuth : ConnectPayment
    {
      
        public static Task<ConnectPaymentPreAuth> Create(CreateConnectPaymentRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ConnectPaymentPreAuth>(options.BaseUrl + "/payment/iyziconnect/preauth", request);
        }
    }
}
