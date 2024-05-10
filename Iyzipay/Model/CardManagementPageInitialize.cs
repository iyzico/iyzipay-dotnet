using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CardManagementPageInitialize  : IyzipayResource
    {
        public string ExternalId { get; set; }
        public string Token { get; set; }
        public string CardPageUrl { get; set; }
        
        public static Task<CardManagementPageInitialize> Create(CreateCardManagementPageInitializeRequest request, Options options) {
            return RestHttpClient.Create().PostAsync<CardManagementPageInitialize>(options.BaseUrl + "/v1/card-management/pages", GetHttpHeaders(request, options), request);
        }
    }
    
}