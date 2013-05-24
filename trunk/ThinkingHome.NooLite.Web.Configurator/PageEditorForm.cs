using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ThinkingHome.NooLite.Web.Configurator
{
	public partial class PageEditorForm : Form
	{
		private readonly NooliteControlPage page = new NooliteControlPage();

		public PageEditorForm()
		{
			InitializeComponent();
			FillFormControls(page);
		}

		public PageEditorForm(NooliteControlPage p)
		{
			page = p;

			InitializeComponent();
			FillFormControls(page);
		}

		private void FillFormControls(NooliteControlPage p)
		{
			tbIdentifier.Text = p.Id;
			tbTitle.Text = p.Title;
			tbDescription.Text = p.Description;
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
			UpdateModel(page);
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
