using System.Collections.Generic;

namespace ThinkingHome.NooLite.Web.Configuration
{
	public class Control
	{
		public string DisplayText { get; set; }

		public byte Level { get; set; }

		public bool ShowSlider { get; set; }

		public IEnumerable<ControlAction> Actions { get; set; }
	}
}