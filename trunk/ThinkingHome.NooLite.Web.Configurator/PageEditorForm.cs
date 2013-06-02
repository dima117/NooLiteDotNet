using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ThinkingHome.NooLite.Web.Configurator
{
	public partial class PageEditorForm : Form
	{
		public readonly NooliteControlPage Page = new NooliteControlPage();

		public PageEditorForm()
		{
			InitializeComponent();
			FillFormControls(Page);

			Text = "Добавление нового раздела";
		}

		public PageEditorForm(NooliteControlPage p)
		{
			Page = p;

			InitializeComponent();
			FillFormControls(Page);

			Text = "Редактирование раздела";
		}

		private void FillFormControls(NooliteControlPage p)
		{
			tbIdentifier.Text = p.Id;
			tbTitle.Text = p.Title;
			tbDescription.Text = p.Description;

			lbControls.DataSource = p.Controls;
		}

		private void UpdateModel(NooliteControlPage p)
		{
			p.Id = tbIdentifier.Text;
			p.Title = tbTitle.Text;
			p.Description = tbDescription.Text;
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

		private void BtnSaveClick(object sender, System.EventArgs e)
		{
			UpdateModel(Page);
			DialogResult = DialogResult.OK;
			Close();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			using (var form = new ControlEditorForm())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					Page.Controls.Add(form.Control);
					lbControls.DataSource = Page.Controls;
				}
			}
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			var control = lbControls.SelectedItem as NooliteControl;
			if (control != null)
			{
				using (var form = new ControlEditorForm(control))
				{
					if (form.ShowDialog() == DialogResult.OK)
					{
						lbControls.DataSource = Page.Controls;
					}
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var control = lbControls.SelectedItem as NooliteControl;

			if (control != null)
			{
				var confirmation = MessageBox.Show(
					"Элемент управления будет удален. Продолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

				if (confirmation == DialogResult.Yes)
				{
					Page.Controls.Remove(control);
				}
			}
		}

		private void btnUp_Click(object sender, EventArgs e)
		{
			var index = lbControls.SelectedIndex;

			if (index > 0)
			{
				var page = Page.Controls[index];
				Page.Controls.RemoveAt(index);
				Page.Controls.Insert(index - 1, page);

				lbControls.SelectedIndex = index - 1;
			}
		}

		private void btnDown_Click(object sender, EventArgs e)
		{
			var index = lbControls.SelectedIndex;

			if (index >= 0 && index < Page.Controls.Count - 1)
			{
				var page = Page.Controls[index];
				Page.Controls.RemoveAt(index);
				Page.Controls.Insert(index + 1, page);

				lbControls.SelectedIndex = index + 1;
			}
		}
	}
}
