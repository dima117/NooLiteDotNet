using System;
using System.Configuration;

namespace ThinkingHome.NooLite.Web.Configuration
{
	[ConfigurationCollection(typeof(ControlElement), AddItemName = "control")]
	public class ControlElementCollection: ConfigurationElementCollection
	{
		public ControlElementCollection()
			: base(StringComparer.OrdinalIgnoreCase)
		{
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new ControlElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((ControlElement)element).Id;
		}
	}
}