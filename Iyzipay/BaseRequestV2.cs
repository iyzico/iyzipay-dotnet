using Newtonsoft.Json;
using System;

namespace Iyzipay
{
    public class BaseRequestV2
    {
        [JsonIgnore]
        public String ConversationId { get; set; }
    }
}
