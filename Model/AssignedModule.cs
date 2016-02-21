using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Orationi.CommunicationCore.Model
{
	/// <summary>
	/// Slave assigned module.
	/// </summary>
	[DataContract]
	public class AssignedModule
	{
		/// <summary>
		/// Slave identifier.
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public Guid SlaveId { get; set; }

		/// <summary>
		/// Module version.
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public ModuleVersionItem ModuleVersion { get; set; }
	}
}
