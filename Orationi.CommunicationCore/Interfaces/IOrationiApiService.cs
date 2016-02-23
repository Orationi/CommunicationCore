using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;
using Orationi.CommunicationCore.Model;

namespace Orationi.CommunicationCore.Interfaces
{
	[ServiceContract(Namespace = "https://orationi.org/master/api/v1/", SessionMode = SessionMode.NotAllowed)]
	public interface IOrationiApiService
	{
		[WebInvoke(UriTemplate = "Version/",
		Method = "GET",
		ResponseFormat = WebMessageFormat.Json,
		RequestFormat = WebMessageFormat.Json,
		BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		[OperationContract]
		string GetVersion();

		[WebInvoke(UriTemplate = "Slaves/",
			Method = "GET",
			ResponseFormat = WebMessageFormat.Json,
			RequestFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		[OperationContract]
		OrationiSlaveItem[] GetSlavesList();

		[WebInvoke(UriTemplate = "Modules/",
			Method = "GET",
			ResponseFormat = WebMessageFormat.Json,
			RequestFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		[OperationContract]
		ModuleItem[] GetModulesList();

		[WebInvoke(UriTemplate = "Module/{module}/Versions/",
			Method = "GET",
			ResponseFormat = WebMessageFormat.Json,
			RequestFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		[OperationContract]
		ModuleVersionItem[] GetModuleVerionsList(string module);

		[WebInvoke(UriTemplate = "Module/{moduleName}/",
			Method = "POST",
			ResponseFormat = WebMessageFormat.Json,
			RequestFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		[OperationContract]
		ModuleItem RegisterModule(string moduleName);

		[WebInvoke(UriTemplate = "Unregister/Module/{module}/",
			Method = "DELETE",
			ResponseFormat = WebMessageFormat.Json,
			RequestFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		[OperationContract]
		AssignedModule[] UnregisterModule(string module);

		[WebInvoke(UriTemplate = "Slave/{slave}/Assign/Module/{module}/",
			Method = "PUT",
			ResponseFormat = WebMessageFormat.Json,
			RequestFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		[OperationContract]
		AssignedModule AssignModule(string slave, string module);

		[WebInvoke(UriTemplate = "Slave/{slave}/Unassign/Module/{module}/",
			Method = "DELETE",
			ResponseFormat = WebMessageFormat.Json,
			RequestFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		[OperationContract]
		void UnassignModule(string slave, string module);

		[WebInvoke(UriTemplate = "Module/{module}/Version/{major}/{minor}/{build}/{revision}/",
			Method = "POST",
			ResponseFormat = WebMessageFormat.Json,
			RequestFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		[OperationContract]
		void UploadModuleVersion(string module, string major, string minor, string build, string revision, Stream packageStream);
	}
}
