using System;
using System.Collections.Generic;

namespace Iyzipay.Model
{
    public class InitialConsumer
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public String GsmNumber { get; set; }
        public List<IyziupAddress> AddressList { get; set; }
        
        public string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("name", Name)
                .Append("surname", Surname)
                .Append("email", Email)
                .Append("gsmNumber", GsmNumber)
                .Append("addressList", AddressList)
                .GetRequestString();
        }
    }
}