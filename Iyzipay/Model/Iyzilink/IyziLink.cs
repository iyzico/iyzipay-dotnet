using System;
using Iyzipay.Request;

namespace Iyzipay.Model.Iyzilink
{
    public class IyziLink : IyzipayResourceV2
    {
        private static string V2_IYZILINK_PRODUCTS = "/v2/iyzilink/products";
        
        public static IyziLinkSaveResource Create(IyziLinkSaveRequest request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + GetQueryParams(request);
            return RestHttpClientV2.Create().Post<IyziLinkSaveResource>(uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static IyziLinkSaveResource Update(string token, IyziLinkSaveRequest request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + "/" + token + GetQueryParams(request);
            return RestHttpClientV2.Create().Put<IyziLinkSaveResource>(uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static IyziLinkPagingResource RetrieveAll(PagingRequest request, Options options)
        {
            string queryParams = GetQueryParams(request);
            string iyzilinkQueryParam = "productType=IYZILINK";
            
            queryParams = String.IsNullOrEmpty(queryParams)
                ? "?" + iyzilinkQueryParam
                : queryParams + "&" + iyzilinkQueryParam;
            
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + queryParams;
            return RestHttpClientV2.Create().Get<IyziLinkPagingResource>(uri, GetHttpHeadersWithUrlParams(request,uri ,options));
        }
        
        public static IyziLinkResource Retrieve(string token, BaseRequestV2 request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + "/" + token + GetQueryParams(request);
            return RestHttpClientV2.Create().Get<IyziLinkResource>(uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        public static IyzipayResourceV2 Delete(string token, BaseRequestV2 request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + "/" + token + GetQueryParams(request);
            return RestHttpClientV2.Create().Delete<IyzipayResourceV2>(uri, GetHttpHeadersWithRequestBody(request, uri ,options),request);
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