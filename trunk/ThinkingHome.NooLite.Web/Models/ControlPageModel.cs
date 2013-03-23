using System.Collections.Generic;

namespace ThinkingHome.NooLite.Web.Models
{
	public class ControlPageModel
	{
		public ControlPageModel()
		{
			Controls = new List<ControlModel>();
		}

		public string Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public List<ControlModel> Controls { get; set; }
	}
}