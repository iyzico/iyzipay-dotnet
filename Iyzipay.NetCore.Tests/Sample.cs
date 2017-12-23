using System.Diagnostics;
using Iyzpay.NetCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;

namespace Iyzipay.NetCore.Tests
{
    public class Sample
    {
        protected Options options;

        [SetUp]
        public void Initialize()
        {
            options = new Options
            {
                ApiKey = "api key",
                SecretKey = "secret key",
                BaseUrl = "https://sandbox-api.iyzipay.com"
            };
        }

        protected void PrintResponse<T>(T resource)
        {
            Trace.Listeners.Add(new DefaultTraceListener());
            Trace.WriteLine(JsonConvert.SerializeObject(resource, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }));
        }
    }
}
