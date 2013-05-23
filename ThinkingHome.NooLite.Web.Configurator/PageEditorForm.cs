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
	}
}
