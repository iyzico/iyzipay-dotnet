using System;
using Iyzipay.Request.V2.Subscription;

namespace Iyzipay.Model.V2.Subscription
{
    public class Customer : IyzipayResourceV2
    {
        public static ResponseData<CustomerResource> Create(CreateCustomerRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers";
            return RestHttpClientV2.Create().Post<ResponseData<CustomerResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static ResponseData<CustomerResource> Update(UpdateCustomerRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers/{request.CustomerReferenceCode}";
            return RestHttpClientV2.Create().Post<ResponseData<CustomerResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static ResponseData<CustomerResource> Retrieve(RetrieveCustomerRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers/{request.CustomerReferenceCode}";
            return RestHttpClientV2.Create().Get<ResponseData<CustomerResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        public static ResponsePagingData<CustomerResource> RetrieveAll(PagingRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers{GetQueryParams(request)}";
            return RestHttpClientV2.Create().Get<ResponsePagingData<CustomerResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        
        private static string GetQueryParams(BaseRequestV2 request) {
            if (request == null) {
                return "";
            }

            string queryParams = "?conversationId=" + request.ConversationId;

            if (!String.IsNullOrEmpty(request.Locale)) {
                queryParams += "&locale=" + request.Locale;
            }

            if (!(request is PagingRequest pagingRequest)) return queryParams;
            
            if (pagingRequest.Page != null) {
                queryParams += "&page=" + pagingRequest.Page;
            }

            if (pagingRequest.Count != null) {
                queryParams += "&count=" + pagingRequest.Count;
            }
            return queryParams;
        }
    }
}