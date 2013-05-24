using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using ThinkingHome.NooLite.Web.Configurator.Annotations;

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
		public BindingList<NooliteControlPage> Pages { get; set; }
	}

	public class NooliteControlPage : INotifyPropertyChanged
	{
		private string title;

		[XmlAttribute("id")]
		public string Id { get; set; }

		[XmlAttribute("title")]
		public string Title
		{
			get { return title; }
			set { title = value; OnPropertyChanged("Title"); }
		}

		[XmlAttribute("description")]
		public string Description { get; set; }

		[XmlElement("control")]
		public List<NooliteControl> Controls { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
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
