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
		}

		private void UpdateModel(NooliteControl control)
		{
			control.Id = tbIdentifier.Text;
			control.DisplayText = tbTitle.Text;

			ControlType type;
			control.ControlType = Enum.TryParse(ddlControlType.SelectedText, out type)
				                      ? type
				                      : ControlType.Button;
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
	}
}
