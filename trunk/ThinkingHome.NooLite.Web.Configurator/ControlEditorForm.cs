using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
	}
}
