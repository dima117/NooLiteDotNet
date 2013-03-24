#define NOOLITE_DEBUG

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using ThinkingHome.NooLite.Web.Configuration;
using ThinkingHome.NooLite.Web.Models;



namespace ThinkingHome.NooLite.Web.Controllers
{
	public class HomeController : Controller
	{
#if NOOLITE_DEBUG

		private static readonly List<string> channelNames = new List<string>
				{
					"Свет в спальне", "Ночник", "Свет в коридоре", "Свет в маленьком коридоре"
				};

#endif

		private static readonly NooLiteConfigurationSection current =
			ConfigurationManager.GetSection("nooLiteConfiguration") as NooLiteConfigurationSection;

		/// <summary>
		/// Системные настройки (находятся в конфигурационном файле приложения)
		/// </summary>
		public static NooLiteConfigurationSection CurrentConfig
		{
			get { return current; }
		}

		public ActionResult Index()
		{
			var model = new List<ControlPageModel>();

			foreach (ControlPageElement page in CurrentConfig.ControlPages)
			{
				var pageModel = new ControlPageModel
					{
						Id = page.Id,
						Title = page.Title,
						Description = page.Description
					};

				foreach (ControlElement control in page.Controls)
				{
					var controlModel = new ControlModel
					{
						Id = control.Id,
						DisplayText = control.DisplayText,
						Level = control.Level,
						TemplateName = control.Type.ToString()
					};

					pageModel.Controls.Add(controlModel);
				}

				model.Add(pageModel);
			}


			return View(model);
		}

		public ActionResult Command(string page, string control, byte level, bool strong)
		{
			var messages = new List<string>();

			try
			{
				var commands = GetCommandList(page, control, level, strong);

#if NOOLITE_DEBUG

				foreach (var cmd in commands)
				{
					string channelName = channelNames[cmd.Channel];
					string actionName = cmd.Command == Pc118Command.SetLevel
											? string.Format("set level {0}", cmd.Level)
											: cmd.Command.ToString().ToLower();

					string msg = string.Format("{0} (channel {1}): {2}", channelName, cmd.Channel, actionName);
					messages.Add(msg);
				}

#else

				using (var adapter = new PC118Adapter())
				{
					if (adapter.OpenDevice())
					{
						foreach (var cmd in commands)
						{
							adapter.SendCommand(cmd.Command, cmd.Channel, cmd.Level);
						}
					}
				}

#endif


			}
			catch (Exception ex)
			{
				messages.Add(ex.Message);
			}


			return Json(messages, JsonRequestBehavior.AllowGet);
		}

		private static List<Pc118CommandData> GetCommandList(string pageId, string controlId, byte level, bool strong)
		{
			var result = new List<Pc118CommandData>();

			var page = CurrentConfig.ControlPages.GetPage(pageId);

			if (page != null)
			{
				var control = page.Controls.GetControl(controlId);

				if (control != null)
				{
					foreach (ChannelElement channel in control.Channels)
					{
						var lvl = strong ? level : channel.Level.GetValueOrDefault(level);
						var cmd =
							level == 0 ? Pc118Command.Off :
							level < 100 ? Pc118Command.SetLevel :
								Pc118Command.On;

						result.Add(new Pc118CommandData { Channel = channel.Id, Command = cmd, Level = lvl });
					}
				}
			}

			return result;
		}
	}
}
