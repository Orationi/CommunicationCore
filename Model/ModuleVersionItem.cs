using System.Runtime.Serialization;

namespace Orationi.CommunicationCore.Model
{
	/// <summary>
	/// Provide information about module version.
	/// </summary>
	[DataContract]
	public class ModuleVersionItem
	{
		/// <summary>
		/// Module identifier.
		/// </summary>
		[DataMember(Order = 0)]
		public int ModuleId { get; set; }

		/// <summary>
		/// Major version.
		/// </summary>
		[DataMember(Order = 1)]
		public int Major { get; set; }

		/// <summary>
		/// Minor version.
		/// </summary>
		[DataMember(Order = 2)]
		public int Minor { get; set; }

		/// <summary>
		/// Build version.
		/// </summary>
		[DataMember(Order = 3)]
		public int Build { get; set; }

		/// <summary>
		/// Revision.
		/// </summary>
		[DataMember(Order = 4)]
		public int Revision { get; set; }
	}
}