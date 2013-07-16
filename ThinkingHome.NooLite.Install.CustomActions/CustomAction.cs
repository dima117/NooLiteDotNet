using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Deployment.WindowsInstaller;
using UWS.Configuration;

namespace ThinkingHome.NooLite.Install.CustomActions
{
	public class CustomActions
	{
		[CustomAction]
		public static ActionResult RegisterApplication(Session session)
		{
			Debugger.Launch();

			try
			{
				Guid appId = new Guid(session["APP_ID"]);
				ushort port = ushort.Parse(session["APP_PORT"]);
				string path = Path.Combine(session["APP_PATH"], "webapp");

				session.Log("Begin Configure EWS Filter Custom Action");

				WebAppConfigEntry app = Metabase.GetWebAppEntry(appId);
				app.PhysicalDirectory = path;
				app.ListenAddresses.AddAddresses(new ListenAddress(port));
				app.ApplicationName = "My Test API-Registered UWS Application";
				Metabase.RegisterApplication(RuntimeVersion.AspNet_4, false, app, new AppShortcut[0]);



				session.Log("End Configure EWS Filter Custom Action");
			}
			catch (Exception ex)
			{
				session.Log("ERROR in custom action ConfigureEwsFilter {0}", ex.ToString());
				return ActionResult.Failure;
			}

			return ActionResult.Success;
		}
	}
}
