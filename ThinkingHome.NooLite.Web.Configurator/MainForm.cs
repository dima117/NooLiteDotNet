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
	public partial class MainForm : Form
	{
		private readonly NooLiteConfiguration config;

		public MainForm()
		{
			InitializeComponent();

			config = Config.Load();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Config.SaveConfig(config);
			Close();
		}
	}
}
