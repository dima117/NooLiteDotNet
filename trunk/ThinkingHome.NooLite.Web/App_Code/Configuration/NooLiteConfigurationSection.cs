using System.Configuration;

namespace ThinkingHome.NooLite.Web.Configuration
{
	public class NooLiteConfigurationSection : ConfigurationSection
	{
		private static readonly ConfigurationProperty propControlPages = new ConfigurationProperty(null, typeof(ControlPageElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);

		[ConfigurationProperty("", IsDefaultCollection = true)]
		public ControlPageElementCollection ControlPages
		{
			get
			{
				return (ControlPageElementCollection)base[propControlPages];
			}
		}

		[ConfigurationProperty("title", DefaultValue = "Комнаты")]
		public string Title
		{
			get { return (string)base["title"]; }
			set { base["title"] = value; }
		}

		[ConfigurationProperty("debug", DefaultValue = false)]
		public bool Debug
		{
			get { return (bool)base["debug"]; }
			set { base["debug"] = value; }
		}
	}
}