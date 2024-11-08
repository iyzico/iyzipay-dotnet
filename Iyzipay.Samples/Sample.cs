using Newtonsoft.Json;
﻿using System.Diagnostics;
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
            options.ApiKey = "sandbox-X8Qfwvvb16pe2prgfeX857cwiD4bkfAf";
            options.SecretKey = "sandbox-qaIiLIxhjMgx3LSKIVvp6j17NunHOFtD";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";
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
