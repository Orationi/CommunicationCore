using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Orationi.CommunicationCore.DataContracts
{
	[DataContract]
	public class SlaveServiceInfo
	{
		[DataMember]
		public Guid Id { get; set; }

		[DataMember(IsRequired = true)]
		public string Name { get; set; }

		[DataMember]
		public int Status { get; set; }
	}
}
