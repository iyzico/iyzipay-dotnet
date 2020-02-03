using System;
using Iyzipay.Request.V2.Subscription;

namespace Iyzipay.Model.V2.Subscription
{
    public class Subscription : IyzipayResourceV2
    {
        public static CheckoutFormResource InitializeCheckoutForm(InitializeCheckoutFormRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/checkoutform/initialize";
            return RestHttpClientV2.Create().Post<CheckoutFormResource>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static UpdateCardFormResource UpdateCard(UpdateCardRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/card-update/checkoutform/initialize";
            return RestHttpClientV2.Create().Post<UpdateCardFormResource>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static ResponseData<SubscriptionCreatedResource> Initialize(SubscriptionInitializeRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/initialize";
            return RestHttpClientV2.Create().Post<ResponseData<SubscriptionCreatedResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static IyzipayResourceV2 Activate(ActivateSubscriptionRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/subscriptions/{request.SubscriptionReferenceCode}/activate";
            return RestHttpClientV2.Create().Post<IyzipayResourceV2>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static IyzipayResourceV2 Retry(RetrySubscriptionRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/operation/retry";
            return RestHttpClientV2.Create().Post<IyzipayResourceV2>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static IyzipayResourceV2 Upgrade(UpgradeSubscriptionRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/subscriptions/{request.SubscriptionReferenceCode}/upgrade";
            return RestHttpClientV2.Create().Post<IyzipayResourceV2>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static IyzipayResourceV2 Cancel(CancelSubscriptionRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/subscriptions/{request.SubscriptionReferenceCode}/cancel";
            return RestHttpClientV2.Create().Post<IyzipayResourceV2>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        public static ResponseData<SubscriptionResource> Retrieve(RetrieveSubscriptionRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/subscriptions/{request.SubscriptionReferenceCode}";
            return RestHttpClientV2.Create().Get<ResponseData<SubscriptionResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        public static ResponsePagingData<SubscriptionResource> Search(SearchSubscriptionRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/subscriptions{GetQueryParams(request)}";
            return RestHttpClientV2.Create().Get<ResponsePagingData<SubscriptionResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        private static string GetQueryParams(SearchSubscriptionRequest request) {
            if (request == null) {
                return "";
            }

            string queryParams = "?conversationId=" + request.ConversationId;

            if (!String.IsNullOrEmpty(request.Locale)) {
                queryParams += "&locale=" + request.Locale;
            }
            
            if (!String.IsNullOrEmpty(request.PricingPlanReferenceCode)) {
                queryParams += "&pricingPlanReferenceCode=" + request.PricingPlanReferenceCode;
            }
            
            if (!String.IsNullOrEmpty(request.SubscriptionReferenceCode)) {
                queryParams += "&subscriptionReferenceCode=" + request.SubscriptionReferenceCode;
            }
            
            if (!String.IsNullOrEmpty(request.ParentReferenceCode)) {
                queryParams += "&parentReferenceCode=" + request.ParentReferenceCode;
            }
            
            if (!String.IsNullOrEmpty(request.CustomerReferenceCode)) {
                queryParams += "&customerReferenceCode=" + request.CustomerReferenceCode;
            }
            
            if (!String.IsNullOrEmpty(request.SubscriptionStatus)) {
                queryParams += "&subscriptionStatus=" + request.SubscriptionStatus;
            }
            
            if (!String.IsNullOrEmpty(request.StartDate)) {
                queryParams += "&startDate=" + request.StartDate;
            }
            
            if (!String.IsNullOrEmpty(request.EndDate)) {
                queryParams += "&endDate=" + request.EndDate;
            }

            if (request.Page != null) {
                queryParams += "&page=" + request.Page;
            }

            if (request.Count != null) {
                queryParams += "&count=" + request.Count;
            }
            return queryParams;
        }
    }
}