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

		[ConfigurationProperty("level", DefaultValue = (byte)50)]
		public byte Level
		{
			get { return (byte)base["level"]; }
			set { base["level"] = value; }
		}

		[ConfigurationProperty("type", DefaultValue = "Button")]
		public ControlType Type
		{
			get { return (ControlType)base["type"]; }
			set { base["type"] = value; }
		}

		private static readonly ConfigurationProperty propChannels = new ConfigurationProperty(null, typeof(ChannelElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);

		[ConfigurationProperty("", IsDefaultCollection = true)]
		public ChannelElementCollection Channels
		{
			get
			{
				return (ChannelElementCollection)base[propChannels];
			}
		}
	}
}