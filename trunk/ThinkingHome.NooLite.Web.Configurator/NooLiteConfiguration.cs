using System.Collections.Generic;
using System.Xml.Serialization;

namespace ThinkingHome.NooLite.Web.Configurator
{
	[XmlRoot("nooLiteConfiguration")]
	public class NooLiteConfiguration
	{
		[XmlAttribute("title")]
		public string Title { get; set; }

		[XmlAttribute("debug")]
		public bool Debug { get; set; }

		[XmlElement("page")]
		public List<NooliteControlPage> Pages { get; set; }
	}

	public class NooliteControlPage
	{
		[XmlAttribute("id")]
		public string Id { get; set; }

		[XmlAttribute("title")]
		public string Title { get; set; }

		[XmlAttribute("description")]
		public string Description { get; set; }

		[XmlElement("control")]
		public List<NooliteControl> Controls { get; set; }

		public override string ToString()
		{
			return Title;
		}
	}
	public class NooliteControl
	{
		[XmlAttribute("id")]
		public string Id { get; set; }

		[XmlAttribute("displayText")]
		public string DisplayText { get; set; }

		[XmlAttribute("type")]
		public ControlType ControlType { get; set; }

		[XmlAttribute("level")]
		public byte Level { get; set; }

		[XmlElement("channel")]
		public List<NooliteChannelAction> Actions { get; set; }

	}

	public class NooliteChannelAction
	{
		[XmlAttribute("id")]
		public byte ChannelId { get; set; }

		[XmlAttribute("level")]
		public string LevelText { get; set; }

		[XmlIgnore]
		public byte? Level
		{
			get
			{
				byte result;
				return byte.TryParse(LevelText, out result) ? (byte?)result : null;
			}
			set
			{
				LevelText = value.HasValue ? value.ToString() : null;
			}
		}
	}
}
