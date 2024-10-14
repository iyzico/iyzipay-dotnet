using System;

namespace Iyzipay.Request
{
	public class CreateC2CSubMerchantRequest : BaseRequestV2
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string GsmNumber { get; set; }
        public string TckNo { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string ExternalId { get; set; }
    }
}
