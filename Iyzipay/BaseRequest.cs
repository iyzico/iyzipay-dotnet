using System;

namespace Iyzipay
{
    public class BaseRequest : RequestStringConvertible
    {
        public String Locale { get; set; }
        public String ConversationId { get; set; }

        public virtual String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("locale", Locale)
                .Append("conversationId", ConversationId)
                .GetRequestString();
        }
    }
}
