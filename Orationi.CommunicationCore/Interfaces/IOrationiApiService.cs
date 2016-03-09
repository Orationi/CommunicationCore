using System;
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
        ModuleVersionItem[] GetModuleVerionsList(int moduleId);

        [OperationContract]
        ModuleItem RegisterModule(string moduleName);

        [OperationContract]
        AssignedModule[] UnregisterModule(int moduleId);

        [OperationContract]
        AssignedModule AssignModule(Guid slaveId, int moduleId);

        [OperationContract]
        void UnassignModule(Guid slaveId, int moduleId);

        [OperationContract]
        void ExecutePowerShell(Guid slaveId, string script);

        [OperationContract]
        void UploadModuleVersion(int moduleId, string major, string minor, string build, string revision, Stream packageStream);
    }
}
