using System.IO;
using System.ServiceModel;
using Orationi.CommunicationCore.Model;

namespace Orationi.CommunicationCore.Interfaces
{
	[ServiceContract(Namespace = "https://orationi.org/master/Api/v1/", SessionMode = SessionMode.Required)]
	public interface IOrationiApiService
	{
		[OperationContract]
		string GetVersion();

		[OperationContract]
		OrationiSlaveItem[] GetSlavesList();

		[OperationContract]
		ModuleItem[] GetModulesList();

		[OperationContract]
		ModuleVersionItem[] GetModuleVerionsList(string module);

		[OperationContract]
		ModuleItem RegisterModule(string moduleName);

		[OperationContract]
		AssignedModule[] UnregisterModule(string module);

		[OperationContract]
		AssignedModule AssignModule(string slave, string module);

		[OperationContract]
		void UnassignModule(string slave, string module);

		[OperationContract]
		void ExecutePowerShell(string slave, string script);

		[OperationContract]
		void UploadModuleVersion(string module, string major, string minor, string build, string revision, Stream packageStream);
	}
}
