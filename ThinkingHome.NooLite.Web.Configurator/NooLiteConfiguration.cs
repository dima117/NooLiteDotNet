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
		public BindingList<NooliteControl> Controls { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	public class NooliteControl : INotifyPropertyChanged
	{
		private string displayText;
		private ControlType controlType;

		[XmlAttribute("id")]
		public string Id { get; set; }

		[XmlAttribute("displayText")]
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; OnPropertyChanged("ConfiguratorUiDisplayText"); }
		}

		[XmlAttribute("type")]
		public ControlType ControlType
		{
			get { return controlType; }
			set { controlType = value; OnPropertyChanged("ConfiguratorUiDisplayText"); }
		}

		[XmlAttribute("level")]
		public byte Level { get; set; }

		[XmlElement("channel")]
		public BindingList<NooliteChannelAction> Actions { get; set; }

		[XmlIgnore]
		public string ConfiguratorUiDisplayText
		{
			get { return string.Format("{0} ({1})", DisplayText, ControlType); }
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public class NooliteChannelAction : INotifyPropertyChanged
	{
		private byte channelId;

		[XmlAttribute("id")]
		public byte ChannelId
		{
			get { return channelId; }
			set { channelId = value; OnPropertyChanged("ConfiguratorUiDisplayText"); }
		}

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
				OnPropertyChanged("ConfiguratorUiDisplayText");
			}
		}

		[XmlIgnore]
		public string ConfiguratorUiDisplayText
		{
			get
			{
				var level = (object)Level ?? "default";
				return string.Format("канал: {0} (яркость: {1})", ChannelId, level);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
