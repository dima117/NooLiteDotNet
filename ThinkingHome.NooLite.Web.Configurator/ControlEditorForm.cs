using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ThinkingHome.NooLite.Web.Configurator
{
	public partial class ControlEditorForm : Form
	{

		public readonly NooliteControl Control = new NooliteControl();

		public ControlEditorForm()
		{
			InitializeComponent();
			FillFormControls(Control);

			Text = "Добавление нового элемента управления";
		}

		public ControlEditorForm(NooliteControl с)
		{
			Control = с;

			InitializeComponent();
			FillFormControls(Control);

			Text = "Редактирование элемента управления";
		}

		private void FillFormControls(NooliteControl control)
		{
			tbIdentifier.Text = control.Id;
			tbTitle.Text = control.DisplayText;

			var index = ddlControlType.FindStringExact(control.ControlType.ToString());
			ddlControlType.SelectedIndex = index;

			var level = control.Level > 100 ? 100 : control.Level;

			lbChannelActions.DataSource = control.Actions;

			trbDefaultLevel.Value = level / 10;
		}

		private void UpdateModel(NooliteControl control)
		{
			control.Id = tbIdentifier.Text;
			control.DisplayText = tbTitle.Text;

			ControlType type;
			string strType = (ddlControlType.SelectedItem ?? string.Empty).ToString();
			control.ControlType = Enum.TryParse(strType, out type) ? type : ControlType.Button;
			control.Level = (byte)(trbDefaultLevel.Value * 10);
		}

		private void TbIdentifierValidating(object sender, CancelEventArgs e)
		{
			var tb = sender as TextBox;

			if (tb != null)
			{
				string error = null;

				if (!Regex.IsMatch(tb.Text, @"^[-a-z1-9]+$"))
				{
					error = "Разрешены следующие символы: английские буквы, цифры, дефис";
					e.Cancel = true;
				}

				errorProvider1.SetError(tb, error);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			UpdateModel(Control);
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			byte[] ids = Control.Actions.Select(x => x.ChannelId).ToArray();

			using (var form = new ChannelActionEditorForm(ids))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					var action = new NooliteChannelAction
					{
						ChannelId = form.ChannelId.Value,
						Level = form.Level
					};

					Control.Actions.Add(action);
					lbChannelActions.DataSource = Control.Actions;
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			byte[] ids = Control.Actions.Select(x => x.ChannelId).ToArray();

			var action = lbChannelActions.SelectedItem as NooliteChannelAction;

			if (action != null)
			{
				using (var form = new ChannelActionEditorForm(ids, action.ChannelId, action.Level))
				{
					if (form.ShowDialog() == DialogResult.OK)
					{
						action.ChannelId = form.ChannelId.Value;
						action.Level = form.Level;
						lbChannelActions.DataSource = Control.Actions;
					}
				}
			}
		}
	}
}
