using Iyzipay;
using Iyzipay.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace iyzipay_dotnet_sample.sample
{
    class ApiTestSample
    {
        public async void Should_Test_Api()
        {
            Options options = new Options();
            options.ApiKey = "apiKey";
            options.SecretKey = "secretKey";
            options.BaseUrl = "baseUrl";

            IyzipayResource iyzipayResource = await ApiTest.Retrieve(options);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(JsonConvert.SerializeObject(iyzipayResource, new JsonSerializerSettings() { Formatting = Formatting.Indented, ContractResolver = new CamelCasePropertyNamesContractResolver() }));
        }
    }
}
