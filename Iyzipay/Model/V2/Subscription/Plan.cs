using System;
using Iyzipay.Request.V2.Subscription;

namespace Iyzipay.Model.V2.Subscription
{
    public class Plan : IyzipayResourceV2
    {
        public static ResponseData<PlanResource> Create(CreatePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/products/{request.ProductReferenceCode}/pricing-plans";
            return RestHttpClientV2.Create().Post<ResponseData<PlanResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static ResponseData<PlanResource> Update(UpdatePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/pricing-plans/{request.PricingPlanReferenceCode}";
            return RestHttpClientV2.Create().Post<ResponseData<PlanResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static IyzipayResourceV2 Delete(DeletePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/pricing-plans/{request.PricingPlanReferenceCode}";
            return RestHttpClientV2.Create().Delete<IyzipayResourceV2>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static ResponseData<PlanResource> Retrieve(RetrievePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/pricing-plans/{request.PricingPlanReferenceCode}";
            return RestHttpClientV2.Create().Get<ResponseData<PlanResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        public static ResponsePagingData<PlanResource> RetrieveAll(RetrieveAllPlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/products/{request.ProductReferenceCode}/pricing-plans{GetQueryParams(request)}";
            return RestHttpClientV2.Create().Get<ResponsePagingData<PlanResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
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