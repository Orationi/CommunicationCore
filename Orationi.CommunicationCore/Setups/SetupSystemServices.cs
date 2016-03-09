using System.Diagnostics;
using System.Linq;

namespace Orationi.CommunicationCore.Setups
{
	public static class SetupSystemServices
	{
		public static string[] IisFeatureNames = {
				"IIS-ApplicationDevelopment",
				"IIS-CommonHttpFeatures",
				"IIS-DefaultDocument",
				"IIS-ISAPIExtensions",
				"IIS-ISAPIFilter",
				"IIS-ManagementConsole",
				"IIS-NetFxExtensibility",
				"IIS-RequestFiltering",
				"IIS-Security",
				"IIS-StaticContent",
				"IIS-WebServer",
				"IIS-WebServerRole",
			};

		public static string SetupIIS(string[] featureNames)
		{
			return Run("dism", string.Format("/NoRestart /Online /Enable-Feature {0}",
				string.Join(" ", featureNames.Select(name => string.Format("/FeatureName:{0}", name)))));
		}

		public static string Run(string fileName, string arguments)
		{
			using (var process = Process.Start(new ProcessStartInfo
			{
				FileName = fileName,
				Arguments = arguments,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				RedirectStandardOutput = true,
				UseShellExecute = false,
			}))
			{
				process.WaitForExit();
				return process.StandardOutput.ReadToEnd();
			}
		}
	}
}
