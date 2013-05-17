using System.Collections.Generic;

namespace ThinkingHome.NooLite.Web.Configurator
{
	public class ConfigModel
	{
		public ConfigModel()
		{
			Groups = new List<GroupModel>();
		}

		public string ApplicationTitle { get; set; }

		public bool Debug { get; set; }

		public List<GroupModel> Groups { get; private set; }
	}
}
