using System.Configuration;

namespace ThinkingHome.NooLite.Web.Configuration
{
	public class NooLiteConfigurationSection : ConfigurationSection
	{
		private static readonly ConfigurationProperty propControlPages = new ConfigurationProperty(null, typeof(ControlPageCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);

		[ConfigurationProperty("", IsDefaultCollection = true)]
		public ControlPageCollection ControlPages
		{
			get
			{
				return (ControlPageCollection)base[propControlPages];
			}
		}
	}
}