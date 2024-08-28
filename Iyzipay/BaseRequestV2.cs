using System;

namespace Iyzipay
{
	public class BaseRequestV2 : RequestStringConvertible
	{
		public string Locale { get; set; }
		public string ConversationId { get; set; }

		public virtual string ToPKIRequestString()
		{
			return ToStringRequestBuilder.NewInstance()
				.Append("locale", Locale)
				.Append("conversationId", ConversationId)
				.GetRequestString();
		}
	}
}
