using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThinkingHome.NooLite.Web.Configurator
{
	public partial class ChannelActionEditorForm : Form
	{
		public ChannelActionEditorForm()
		{
			InitializeComponent();
		}

		public ChannelActionEditorForm(int[] usedIds)
		{
			
		}

		private void cbSpecificLevel_CheckedChanged(object sender, EventArgs e)
		{
			trbLevel.Enabled = lblLevel.Enabled = cbSpecificLevel.Checked;
		}
	}
}
