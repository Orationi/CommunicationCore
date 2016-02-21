using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Orationi.CommunicationCore.Model
{
	[DataContract]
	public class PushedMessage
	{
		[DataMember]
		public DateTime CreatedOn { get; set; }

		[DataMember]
		public string InnerSource { get; set; }

		[DataMember]
		public string Message { get; set; }

		public PushedMessage()
		{
			CreatedOn = DateTime.Now;
		}
	}
}
