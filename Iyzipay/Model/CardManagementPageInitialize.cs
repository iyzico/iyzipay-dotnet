using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class CardManagementPageInitialize  : IyzipayResource
    {
        public string ExternalId { get; set; }
        public string Token { get; set; }
        public string CardPageUrl { get; set; }
        
        public static CardManagementPageInitialize Create(CreateCardManagementPageInitializeRequest request, Options options) {
            return RestHttpClient.Create().Post<CardManagementPageInitialize>(options.BaseUrl + "/v1/card-management/pages", GetHttpHeaders(request, options), request);
        }
    }
    
}