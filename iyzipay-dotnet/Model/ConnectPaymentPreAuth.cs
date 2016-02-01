using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectPaymentPreAuth : ConnectPayment
    {
      
        public static Task<ConnectPaymentPreAuth> Create(CreateConnectPaymentRequest request, Options options)
        {
            return new RestHttpClient().Post<ConnectPaymentPreAuth>(options.BaseUrl + "/payment/iyziconnect/preauth", GetHttpHeaders(request, options), request);
        }
    }
}
