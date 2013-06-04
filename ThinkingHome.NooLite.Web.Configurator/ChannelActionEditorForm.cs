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
		public byte? ChannelId { get; private set; }
		public byte? Level { get; private set; }

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

			FillFormControls();
		}

		public ChannelActionEditorForm(byte[] ids, byte channelId, byte? level)
		{
			InitializeComponent();
			ChannelId = channelId;
			Level = level;
			usedIds = ids;

			FillFormControls();
		}

		private void FillFormControls()
		{
			for (byte i = 0; i < MAX_CHANNEL_COUNT; i++)
			{
				if (!usedIds.Contains(i) || ChannelId == i)
				{
					ddlChannelIds.Items.Add(i);
				}
			}

			if (ChannelId.HasValue && ChannelId.Value < MAX_CHANNEL_COUNT)
			{
				ddlChannelIds.SelectedIndex =
					ddlChannelIds.FindStringExact(ChannelId.Value.ToString());
			}

			cbSpecificLevel.Checked =
			trbLevel.Enabled =
			lblLevel.Enabled = Level.HasValue;

			if (Level.HasValue)
			{
				var l = Level.Value;
				var level = l > 100 ? 100 : l;
				trbLevel.Value = level / 10;
			}
		}


		private void cbSpecificLevel_CheckedChanged(object sender, EventArgs e)
		{
			trbLevel.Enabled = lblLevel.Enabled = cbSpecificLevel.Checked;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (UpdateModel())
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private bool UpdateModel()
		{
			if (ddlChannelIds.SelectedItem is byte)
			{
				ChannelId = (byte)ddlChannelIds.SelectedItem;
				Level = cbSpecificLevel.Checked ? (byte)(trbLevel.Value * 10) : (byte?)null;

				return true;
			}

			errorProvider1.SetError(ddlChannelIds, "Не выбран номер канала");
			return false;
		}
	}
}
