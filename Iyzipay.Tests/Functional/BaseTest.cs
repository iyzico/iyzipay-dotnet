using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class BaseTest
    {
        protected Options _options;

        [SetUp]
        public void Initialize()
        {
            _options = new Options();
            _options.ApiKey = "sandbox-afXhZPW0MQlE4dCUUlHcEopnMBgXnAZI";
            _options.SecretKey = "sandbox-wbwpzKIiplZxI3hh5ALI4FJyAcZKL6kq";
            _options.BaseUrl = "https://sandbox-api.iyzipay.com";
        }

        protected void PrintResponse<T>(T resource)
        {
            TraceListener consoleListener = new ConsoleTraceListener();
            Trace.Listeners.Add(consoleListener);
            Trace.WriteLine(JsonConvert.SerializeObject(resource, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }));
        }
    }
}
