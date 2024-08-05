using Iyzipay.Model;
using System;
using System.Collections.Generic;

namespace Iyzipay.Request
{
    public class CreateBasicBkmInitializeRequest : BaseRequestV2
    {
        public string ConnectorName { get; set; }
        public string Price { get; set; }
        public string CallbackUrl { get; set; }
        public string BuyerEmail { get; set; }
        public string BuyerId { get; set; }
        public string BuyerIp { get; set; }
        public string PosOrderId { get; set; }
        public List<BkmInstallment> InstallmentDetails { get; set; }
        
    }
}
