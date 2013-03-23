using System;
using System.Configuration;

namespace ThinkingHome.NooLite.Web.Configuration
{
	[ConfigurationCollection(typeof(ControlPageElement), AddItemName = "page")]
	public sealed class ControlPageElementCollection : ConfigurationElementCollection
	{
		public ControlPageElementCollection()
			: base(StringComparer.OrdinalIgnoreCase)
		{
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new ControlPageElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((ControlPageElement)element).Id;
		}
	}
}