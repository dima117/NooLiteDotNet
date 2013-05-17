using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ThinkingHome.NooLite.Web.Configurator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			LoadConfig();
		}

		private void LoadConfig()
		{
			var mySerializer = new XmlSerializer(typeof(NooLiteConfiguration));

			var myFileStream = new FileStream("NooLite.config", FileMode.Open);
			// Call the Deserialize method and cast to the object type.
			var obj = mySerializer.Deserialize(myFileStream) as NooLiteConfiguration;

		}
	}
}
