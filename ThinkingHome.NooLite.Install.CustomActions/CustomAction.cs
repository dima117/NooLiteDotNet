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
			session.Log("Begin configure web application");

			try
			{
				// parameters
				Guid appId = new Guid(session["APP_ID"]);
				ushort port = ushort.Parse(session["APP_PORT"]);
				string path = session["APP_PATH"];

				// init
				WebAppConfigEntry app = Metabase.GetWebAppEntry(appId);
				app.PhysicalDirectory = path;
				app.ListenAddresses.AddAddresses(new ListenAddress(port));
				app.ApplicationName = "NooLite Web Control Panel";

				// register webapp
				Metabase.RegisterApplication(RuntimeVersion.AspNet_4, false, app, new AppShortcut[0]);
			}
			catch (Exception ex)
			{
				session.Log("ERROR in configure web application: {0}", ex.ToString());
				return ActionResult.Failure;
			}

			session.Log("End configure web application");
			return ActionResult.Success;
		}		
		
		[CustomAction]
		public static ActionResult UnRegisterApplication(Session session)
		{
			Debugger.Launch();
			session.Log("Begin unregister web application");

			try
			{
				Guid appId = new Guid(session["APP_ID"]);
				Metabase.UnregisterApplication(appId);
			}
			catch (Exception ex)
			{
				session.Log("ERROR in unregister web application: {0}", ex.ToString());
				return ActionResult.Failure;
			}

			session.Log("End unregister web application");
			return ActionResult.Success;
		}
	}
}
