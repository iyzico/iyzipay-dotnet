using System;
using Newtonsoft.Json;


namespace Iyzipay.Request
{
    public class InitUcsRequest : BaseRequestV2
    {
        public string Email { get; set; }
        public string GsmNumber { get; set; }  
    }
}