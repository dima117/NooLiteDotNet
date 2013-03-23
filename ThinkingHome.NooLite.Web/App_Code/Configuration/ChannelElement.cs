using System.Configuration;

namespace ThinkingHome.NooLite.Web.Configuration
{
	public class ChannelElement : ConfigurationElement
	{
		[ConfigurationProperty("id", IsKey = true, IsRequired = true)]
		public byte Id
		{
			get { return (byte)base["id"]; }
			set { base["id"] = value; }
		}

		[ConfigurationProperty("level")]
		public byte? Level
		{
			get { return (byte?)base["level"]; }
			set { base["level"] = value; }
		}
	}
}