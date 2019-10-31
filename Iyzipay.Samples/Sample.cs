using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using System.Diagnostics;

namespace Iyzipay.Samples
{
    public class Sample
    {
        protected Options options;

        [SetUp]
        public void Initialize()
        {
            options = new Options();
            options.ApiKey = "sandbox-afXhZPW0MQlE4dCUUlHcEopnMBgXnAZI";
            options.SecretKey = "sandbox-wbwpzKIiplZxI3hh5ALI4FJyAcZKL6kq";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";
        }

        protected void PrintResponse<T>(T resource)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine(JsonConvert.SerializeObject(resource, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }));
        }
    }
}
