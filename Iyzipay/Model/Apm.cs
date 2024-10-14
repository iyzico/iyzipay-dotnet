using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class Apm : ApmResource
	{
		public static Task<Apm> Create(CreateApmInitializeRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/apm/initialize";
			return RestHttpClientV2.Create().PostAsync<Apm>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}

		public static Task<Apm> Retrieve(RetrieveApmRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/apm/retrieve";
			return RestHttpClientV2.Create().PostAsync<Apm>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}

