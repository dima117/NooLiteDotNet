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
				string path = session["APP_PATH"];

				session.Log("Begin Configure NooLite Web Control Panel Application");

				WebAppConfigEntry app = Metabase.GetWebAppEntry(appId);
				app.PhysicalDirectory = path;
				app.ListenAddresses.AddAddresses(new ListenAddress(port));
				app.ApplicationName = "NooLite Web Control Panel";
				Metabase.RegisterApplication(RuntimeVersion.AspNet_4, false, app, new AppShortcut[0]);



				session.Log("End Configure NooLite Web Control Panel Application");
			}
			catch (Exception ex)
			{
				session.Log("ERROR in Configure NooLite Web Control Panel Application: {0}", ex.ToString());
				return ActionResult.Failure;
			}

			return ActionResult.Success;
		}
	}
}
