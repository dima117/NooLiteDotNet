using System.Configuration;

namespace ThinkingHome.NooLite.Web.Configuration
{
	public class ControlElement : ConfigurationElement
	{
		[ConfigurationProperty("id", IsKey = true, IsRequired = true)]
		public string Id
		{
			get { return (string)base["id"]; }
			set { base["id"] = value; }
		}

		[ConfigurationProperty("displayText", IsRequired = true)]
		public string DisplayText
		{
			get { return (string)base["displayText"]; }
			set { base["displayText"] = value; }
		}

		[ConfigurationProperty("level", IsRequired = true)]
		public byte Level
		{
			get { return (byte)base["level"]; }
			set { base["level"] = value; }
		}

		[ConfigurationProperty("showSlider", DefaultValue = false)]
		public bool ShowSlider
		{
			get { return (bool)base["showSlider"]; }
			set { base["showSlider"] = value; }
		}


		//public IEnumerable<ControlAction> Actions { get; set; }
	}
}