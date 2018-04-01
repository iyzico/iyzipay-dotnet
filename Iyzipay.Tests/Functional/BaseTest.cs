using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class BaseTest
    {
        protected Options Options;

        [SetUp]
        public void SetRequestString()
        {
            Options = new Options();
            Options.ApiKey = "sandbox-afXhZPW0MQlE4dCUUlHcEopnMBgXnAZI";
            Options.SecretKey = "sandbox-wbwpzKIiplZxI3hh5ALI4FJyAcZKL6kq";
            Options.BaseUrl = "https://sandbox-api.iyzipay.com";
        }

        protected void PrintResponse<T>(T resource)
        {
#if NETCORE1 || NETCORE2
            TraceListener consoleListener = new TextWriterTraceListener(System.Console.Out);
#else
            TraceListener consoleListener = new ConsoleTraceListener();
#endif

            Trace.Listeners.Add(consoleListener);
            Trace.WriteLine(JsonConvert.SerializeObject(resource, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }));
        }
    }
}
