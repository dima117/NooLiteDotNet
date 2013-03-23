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
	}
}