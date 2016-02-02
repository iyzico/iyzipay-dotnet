using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace iyzipay_dotnet_sample.sample
{
    class ApprovalSample
    {
        public  void Should_Approve_Payment_Item()
        {
            Options options = new Options();
            options.ApiKey = "apiKey";
            options.SecretKey = "secretKey";
            options.BaseUrl = "baseUrl";

            CreateApprovalRequest request = new CreateApprovalRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "2";

            Approval approval =  Approval.Create(request, options);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(JsonConvert.SerializeObject(approval, new JsonSerializerSettings() { Formatting = Formatting.Indented, ContractResolver = new CamelCasePropertyNamesContractResolver() }));
        }

        public  void Should_Disapprove_Payment_Item()
        {
            Options options = new Options();
            options.ApiKey = "apiKey";
            options.SecretKey = "secretKey";
            options.BaseUrl = "baseUrl";

            CreateApprovalRequest request = new CreateApprovalRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "2";

            Disapproval disapproval =  Disapproval.Create(request, options);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(JsonConvert.SerializeObject(disapproval, new JsonSerializerSettings() { Formatting = Formatting.Indented, ContractResolver = new CamelCasePropertyNamesContractResolver() }));
        }
    }
}
