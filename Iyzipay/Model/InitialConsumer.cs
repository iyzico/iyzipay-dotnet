using System;
using System.Collections.Generic;

namespace Iyzipay.Model
{
    public class InitialConsumer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string GsmNumber { get; set; }
        public List<IyziupAddress> AddressList { get; set; }
    }
}