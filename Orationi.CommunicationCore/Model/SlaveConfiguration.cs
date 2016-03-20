using System;
using System.Runtime.Serialization;

namespace Orationi.CommunicationCore.Model
{
    /// <summary>
    /// Provide information about slave configuration.
    /// </summary>
    [DataContract]
    public class SlaveConfiguration
    {
        /// <summary>
        /// Global slave Id.
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// Versions of slave-assigned modules.
        /// </summary>
        [DataMember]
        public ModuleVersionItem[] Modules { get; set; }
    }
}
