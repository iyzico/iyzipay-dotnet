using Iyzipay.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class InstallmentInfo : IyzipayResourceV2
	{
		public List<InstallmentDetail> InstallmentDetails { get; set; }

		public static Task<InstallmentInfo> Retrieve(RetrieveInstallmentInfoRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/iyzipos/installment";
			return RestHttpClientV2.Create().PostAsync<InstallmentInfo>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
