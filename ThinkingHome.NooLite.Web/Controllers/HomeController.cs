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
		#region debug

		private static readonly List<string> channelNames = new List<string>
			{
				"Канал освещения 0", 
				"Канал освещения 1", 
				"Канал освещения 2", 
				"Канал освещения 3",
				"Канал освещения 4",
				"Канал освещения 5",
				"Канал освещения 6",
				"Канал освещения 7"
			};

		#endregion

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

			var title = CurrentConfig.Title;
			ViewBag.Title = string.IsNullOrWhiteSpace(title) ? "Комнаты" : title;

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

				if (CurrentConfig.Debug)
				{

					foreach (var cmd in commands)
					{
						string channelName = channelNames[cmd.Channel];
						string actionName = cmd.Command == PC11XXCommand.SetLevel
												? string.Format("SET LEVEL {0}", cmd.Level)
												: cmd.Command.ToString().ToUpper();

						string msg = string.Format("{0} (channel {1}): {2}", channelName, cmd.Channel, actionName);
						messages.Add(msg);
					}
				}
				else
				{
					using (var adapter = new PC11XXAdapter())
					{
						if (adapter.OpenDevice())
						{
							foreach (var cmd in commands)
							{
								adapter.SendCommand(cmd.Command, cmd.Channel, cmd.Level);
							}
						}
						else
						{
							messages.Add("PC11xx adapter not found");
						}
					}
				}
			}
			catch (Exception ex)
			{
				messages.Add(ex.Message);
			}


			return Json(messages, JsonRequestBehavior.AllowGet);
		}

		private static List<PC11XXCommandData> GetCommandList(string pageId, string controlId, byte level, bool strong)
		{
			var result = new List<PC11XXCommandData>();

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
							lvl == 0 ? PC11XXCommand.Off :
							lvl < 100 ? PC11XXCommand.SetLevel : PC11XXCommand.On;

						result.Add(new PC11XXCommandData { Channel = channel.Id, Command = cmd, Level = lvl });
					}
				}
			}

			return result;
		}
	}
}
