using System.IO;
using System.ServiceModel;

namespace Orationi.CommunicationCore.Interfaces
{
	public interface IOrationiSlaveCallback
	{
		[OperationContract(IsOneWay = true, IsTerminating = true)]
		void AbortConnection();

		[OperationContract(IsOneWay = true)]
		void PushModule(Stream moduleStream);

		[OperationContract]
		void UndeployModule(int moduleId);

		[OperationContract]
		void ExecutePowerShell(string script);
	}
}
