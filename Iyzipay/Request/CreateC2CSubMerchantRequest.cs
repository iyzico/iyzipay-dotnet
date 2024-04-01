using System;

namespace Iyzipay.Request
{
	public class CreateC2CSubMerchantRequest : BaseRequest
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public String GsmNumber { get; set; }
        public String TckNo { get; set; }
        public String BirthDate { get; set; }
        public String Address { get; set; }
        public String ExternalId { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("name", Name)
                .Append("surname", Surname)
                .Append("gsmNumber", GsmNumber)
                .Append("tckNo", TckNo)
                .Append("birthDate", BirthDate)
                .Append("address", Address)
                .Append("externalId", ExternalId)
                .GetRequestString();
        }
    }
}
