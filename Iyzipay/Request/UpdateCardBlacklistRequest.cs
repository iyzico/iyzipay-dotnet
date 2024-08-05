using Iyzipay.Model;
using System;

namespace Iyzipay.Request
{
    public class UpdateCardBlacklistRequest : BaseRequestV2
    {
        public string CardToken { get; set; }
        public string CardUserKey { get; set; }

    }
}
