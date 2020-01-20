using System;

namespace Iyzipay.Model
{
    public class IyziupAddress
    {
        public String Alias { get; set; }
        public String AddressLine1 { get; set; }
        public String AddressLine2 { get; set; }
        public String ZipCode { get; set; }
        public String ContactName { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        
        public string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("alias", Alias)
                .Append("addressLine1", AddressLine1)
                .Append("addressLine2", AddressLine2)
                .Append("zipCode", ZipCode)
                .Append("contactName", ContactName)
                .Append("city", City)
                .Append("country", Country)
                
                .GetRequestString();
        }
    }
}