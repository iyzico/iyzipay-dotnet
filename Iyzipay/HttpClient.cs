using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Iyzipay
{
    public class HttpClient : System.Net.Http.HttpClient
    {

        public HttpClient()
#if NETSTANDARD
            : base(new HttpClientHandler(){ SslProtocols = SslProtocols.Tls12 } )
#endif
        {
        }
    }
}
