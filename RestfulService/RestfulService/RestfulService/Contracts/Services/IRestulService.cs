using System.ServiceModel;
using RestfulService.Contracts.Data;

namespace RestfulService.Contracts.Services
{
	
	[ServiceContract]
	public interface IRestulService
	{

		[OperationContract]
		string GetData(int value);

		[OperationContract]
		CompositeType GetDataUsingDataContract(CompositeType composite);

	}
}
