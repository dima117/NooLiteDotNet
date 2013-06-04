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
		public readonly NooliteChannelAction ChannelAction = new NooliteChannelAction();
		private readonly byte[] usedIds = new byte[0];
		private const byte MAX_CHANNEL_COUNT = 32;

		public ChannelActionEditorForm()
		{
			InitializeComponent();
		}

		public ChannelActionEditorForm(byte[] ids)
		{
			InitializeComponent();
			usedIds = ids;

			FillFormControls(ChannelAction);
		}

		public ChannelActionEditorForm(byte[] ids, NooliteChannelAction action)
		{
			InitializeComponent();
			ChannelAction = action;
			usedIds = ids;

			FillFormControls(ChannelAction);
		}

		private void FillFormControls(NooliteChannelAction action)
		{
			for (byte i = 0; i < MAX_CHANNEL_COUNT; i++)
			{
				if (!usedIds.Contains(i) || action.ChannelId == i)
				{
					ddlChannelIds.Items.Add(i);
				}
			}

			if (action.ChannelId > 0 && action.ChannelId < MAX_CHANNEL_COUNT)
			{
				ddlChannelIds.SelectedIndex = 
					ddlChannelIds.FindStringExact(action.ChannelId.ToString());
			}

			cbSpecificLevel.Checked = action.Level.HasValue;

			if (action.Level.HasValue)
			{
				var l = action.Level.Value;
				var level = l > 100 ? 100 : l;
				trbLevel.Value = level / 10;
			}
		}


		private void cbSpecificLevel_CheckedChanged(object sender, EventArgs e)
		{
			trbLevel.Enabled = lblLevel.Enabled = cbSpecificLevel.Checked;
		}
	}
}
