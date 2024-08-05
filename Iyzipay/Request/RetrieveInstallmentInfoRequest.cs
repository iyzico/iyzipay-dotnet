using System;

namespace Iyzipay.Request
{
    public class RetrieveInstallmentInfoRequest : BaseRequestV2
    {
        public string BinNumber { get; set; }
        public string Price { get; set; }
    }
}
