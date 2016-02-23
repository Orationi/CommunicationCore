using System.IO;
using System.ServiceModel;
using Orationi.CommunicationCore.Model;

namespace Orationi.CommunicationCore.Interfaces
{
	[ServiceContract(Namespace = "tcp://orationi.org/master/v1/", SessionMode = SessionMode.Required, CallbackContract = typeof(IOrationiSlaveCallback))]
	public interface IOrationiMasterService
	{
		[OperationContract(IsInitiating = true)]
		SlaveConfiguration Connect();

		[OperationContract(IsInitiating = false)]
		void Ping();

		[OperationContract(IsTerminating = true, IsInitiating = false)]
		void Disconnect();

		[OperationContract]
		Stream GetModule(int moduleId);

		[OperationContract(IsOneWay = true)]
		void PushMessage(PushedMessage message);
	}
}
