using System;
using System.Runtime.Serialization;

namespace Orationi.CommunicationCore.Model
{
	/// <summary>
	/// Provide information about slave.
	/// </summary>
	[DataContract]
	public class OrationiSlaveItem
	{
		/// <summary>
		/// Slave identifier.
		/// </summary>
		[DataMember(Order = 0)]
		public Guid Id { get; set; }

		/// <summary>
		/// Slave name.
		/// </summary>
		[DataMember(Order = 1)]
		public string Name { get; set; }

		/// <summary>
		/// Description of slave node.
		/// </summary>
		[DataMember(Order = 2)]
		public string Description { get; set; }

		/// <summary>
		/// Ip address of slave.
		/// </summary>
		[DataMember(Order = 3)]
		public string Address { get; set; }

		/// <summary>
		/// Date and Time of last slave activity or null in case of inactivity.
		/// </summary>
		[DataMember(Order = 4)]
		public DateTime? LastActivity { get; set; }
	}
}
