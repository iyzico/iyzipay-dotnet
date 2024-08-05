using Iyzipay.Model;
using System;

namespace Iyzipay.Request
{
    public class RetrieveCardBlacklistRequest : BaseRequestV2
    {
        public string CardNumber { get; set; }
    }
}
