using System;
using Iyzipay.Request;

namespace Iyzipay.Model.V2.Iyzilink.FastLink
{
	public class FastLink : IyzipayResourceV2
	{
		private static string V2_IYZILINK_FASTLINK_PRODUCTS = "/v2/iyzilink/fast-link/products";
		public static ResponseData<IyziFastLinkSave> Create(IyziFastLinkSaveRequest request, Options options)
		{
			string uri = options.BaseUrl + V2_IYZILINK_FASTLINK_PRODUCTS + GetQueryParams(request);
			return RestHttpClientV2.Create().Post<ResponseData<IyziFastLinkSave>>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}

		private static string GetQueryParams(BaseRequestV2 request)
		{
			if (request == null)
			{
				return "";
			}

			string queryParams = "?conversationId=" + request.ConversationId;

			if (!String.IsNullOrEmpty(request.Locale))
			{
				queryParams += "&locale=" + request.Locale;
			}

			if (!(request is PagingRequest pagingRequest)) return queryParams;

			if (pagingRequest.Page != null)
			{
				queryParams += "&page=" + pagingRequest.Page;
			}

			if (pagingRequest.Count != null)
			{
				queryParams += "&count=" + pagingRequest.Count;
			}
			return queryParams;
		}
	}
}
