using System.Collections.Generic;

namespace ThinkingHome.NooLite.Web.Configuration
{
	public class ControlSection
	{
		public string Title { get; set; }

		public string Description { get; set; }

		public IEnumerable<Control> Controls { get; set; }
	}
}