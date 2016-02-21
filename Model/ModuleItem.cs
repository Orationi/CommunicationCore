using System.Runtime.Serialization;

namespace Orationi.CommunicationCore.Model
{
	/// <summary>
	/// Module item.
	/// Provide main information about module.
	/// </summary>
	[DataContract]
	public class ModuleItem
	{
		/// <summary>
		/// Module identifier.
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public int Id { get; set; }

		/// <summary>
		/// Module name.
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string Name { get; set; }
	}
}