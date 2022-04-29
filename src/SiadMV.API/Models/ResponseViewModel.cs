using SiadMV.ServiceBase.CQRS.SeedWork;

namespace SiadMV.API.Models
{
	public class ResponseViewModel : IResponse, IContract
	{
		public string Message { get; set; }

		public object Data { get; set; }
	}
}
