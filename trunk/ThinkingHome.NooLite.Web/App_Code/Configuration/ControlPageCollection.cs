using System;
using System.Configuration;

namespace ThinkingHome.NooLite.Web.Configuration
{
	[ConfigurationCollection(typeof(ControlPage), AddItemName = "page")]
	public sealed class ControlPageCollection : ConfigurationElementCollection
	{
		public ControlPageCollection()
			: base(StringComparer.OrdinalIgnoreCase)
		{
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new ControlPage();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((ControlPage)element).Id;
		}
	}
}