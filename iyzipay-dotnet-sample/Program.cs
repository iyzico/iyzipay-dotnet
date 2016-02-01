using iyzipay_dotnet_sample.sample;
using System;

namespace iyzipay_dotnet_sample
{
    class Program
    {
        public static void Main(string[] args)
        {
            //new ApiTestSample().Should_Test_Api();
            //new ApprovalSample().Should_Approve_Payment_Item();
            new ApprovalSample().Should_Disapprove_Payment_Item();
            Console.ReadLine();
        }
    }
}
