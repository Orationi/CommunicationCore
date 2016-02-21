using System.Net;
using System.Net.NetworkInformation;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Orationi.CommunicationCore.Interfaces;

namespace Orationi.CommunicationCore.Net
{
	/// <summary>
	/// Provide network methods.
	/// </summary>
	public static class NetworkUtility
	{
		public static IPHostEntry GetHostEntry(string ip)
		{
			IPHostEntry hostEntry = Dns.GetHostEntry(ip);

			if (hostEntry == null)
				throw new NetworkInformationException();

			return hostEntry;
		}

		public static string GetHostName(string ip)
		{
			IPHostEntry hostEntry = GetHostEntry(ip);
			return hostEntry.HostName;
		}

		public static string[] GetHostAliases(string ip)
		{
			IPHostEntry hostEntry = GetHostEntry(ip);
			return hostEntry.Aliases;
		}

		public static IPAddress[] GetIpAddresses(string ip)
		{
			IPHostEntry hostEntry = GetHostEntry(ip);
			return hostEntry.AddressList;
		}

		/// <summary>
		/// Get ip address of client by current OperationContext.
		/// </summary>
		/// <returns>Ip address as string or empty string.</returns>
		public static string GetClientIpFromOperationContext()
		{
			RemoteEndpointMessageProperty endpoint = OperationContext.Current.IncomingMessageProperties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
			if (endpoint != null)
				return endpoint.Address;

			return string.Empty;
		}
	}
}
