using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using ThinkingHome.NooLite.Web.Configuration;
using ThinkingHome.NooLite.Web.Models;

namespace ThinkingHome.NooLite.Web.Controllers
{
	public class HomeController : Controller
	{
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
						TemplateName = "Controls/" + control.Type.ToString()
					};

					pageModel.Controls.Add(controlModel);
				}

				model.Add(pageModel);
			}


			return View(model);
		}

	}
}
