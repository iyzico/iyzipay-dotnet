using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using System.Text;

namespace Iyzipay
{
    public class JsonBuilder
    {
        public static string SerializeToJsonString(BaseRequest request)
        {
            return JsonConvert.SerializeObject(request, new JsonSerializerSettings()
            {
                Formatting = Formatting.None,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }

        public static StringContent ToJsonString(BaseRequest request)
        {
            return new StringContent(SerializeToJsonString(request), Encoding.Unicode, "application/json");
        }
    }
}
