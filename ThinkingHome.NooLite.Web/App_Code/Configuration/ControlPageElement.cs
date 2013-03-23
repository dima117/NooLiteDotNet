using System.Configuration;

namespace ThinkingHome.NooLite.Web.Configuration
{
	public class ControlPageElement : ConfigurationElement
	{
		[ConfigurationProperty("id", IsKey = true, IsRequired = true)]
		public string Id
		{
			get { return (string)base["id"]; }
			set { base["id"] = value; }
		}

		[ConfigurationProperty("title", IsRequired = true)]
		public string Title
		{
			get { return (string)base["title"]; }
			set { base["title"] = value; }
		}

		[ConfigurationProperty("description", IsRequired = false, DefaultValue = "")]
		public string Description
		{
			get { return (string)base["description"]; }
			set { base["description"] = value; }
		}

		private static readonly ConfigurationProperty propControls = new ConfigurationProperty(null, typeof(ControlElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);

		[ConfigurationProperty("", IsDefaultCollection = true)]
		public ControlElementCollection Controls
		{
			get
			{
				return (ControlElementCollection)base[propControls];
			}
		}
	}
}