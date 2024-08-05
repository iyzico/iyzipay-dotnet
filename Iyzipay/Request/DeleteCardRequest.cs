using System;

namespace Iyzipay.Request
{
    public class DeleteCardRequest : BaseRequestV2
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
    }
}
