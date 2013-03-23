using System.Configuration;

namespace ThinkingHome.NooLite.Web.Configuration
{
	public class ControlPage : ConfigurationElement
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

		//public IEnumerable<Control> Controls { get; set; }
	}
}