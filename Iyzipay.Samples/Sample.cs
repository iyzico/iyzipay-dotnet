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
            options.ApiKey = "sandbox-etvOpp5dmDk7VH2HMmmtUoZLCemBiaXE";
            options.SecretKey = "sandbox-tfkpngBqftBTIsQvtaXWubbxRQbchv2r";
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
