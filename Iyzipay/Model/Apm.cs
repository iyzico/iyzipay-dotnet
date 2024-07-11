using Iyzipay.Request;

namespace Iyzipay.Model
{
	public class Apm : ApmResource
	{
		public static Apm Create(CreateApmInitializeRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/apm/initialize";
			return RestHttpClientV2.Create().Post<Apm>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}

		public static Apm Retrieve(RetrieveApmRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/apm/retrieve";
			return RestHttpClientV2.Create().Post<Apm>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
