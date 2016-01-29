using iyzipay_dotnet_sample.sample;
using System;

namespace iyzipay_dotnet_sample
{
    class Program
    {
        public static void Main(string[] args)
        {
            new ApiTestSample().should_test_api();
            Console.ReadLine();
        }
    }
}
