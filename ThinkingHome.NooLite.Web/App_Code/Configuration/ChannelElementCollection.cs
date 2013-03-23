using System;
using System.Configuration;

namespace ThinkingHome.NooLite.Web.Configuration
{
	[ConfigurationCollection(typeof(ChannelElement), AddItemName = "channel")]
	public class ChannelElementCollection: ConfigurationElementCollection
	{
		public ChannelElementCollection()
			: base(StringComparer.OrdinalIgnoreCase)
		{
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new ChannelElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((ChannelElement)element).Id;
		}
	}
}