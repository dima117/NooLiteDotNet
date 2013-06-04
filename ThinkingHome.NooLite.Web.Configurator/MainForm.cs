using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ThinkingHome.NooLite.Web.Configurator
{
	public partial class MainForm : Form
	{
		private readonly NooLiteConfiguration config;

		public MainForm()
		{
			InitializeComponent();

			config = Config.Load();
			FillFormControls(config);
		}

		private void FillFormControls(NooLiteConfiguration cfg)
		{
			tbTitle.Text = cfg.Title;
			cbDebug.Checked = cfg.Debug;
			lbPages.DataSource = cfg.Pages;
		}

		private void UpdateModel(NooLiteConfiguration cfg)
		{
			cfg.Title = tbTitle.Text;
			cfg.Debug = cbDebug.Checked;
		}

		private void BtnSaveClick(object sender, EventArgs e)
		{
			UpdateModel(config);
			Config.SaveConfig(config);
			DialogResult = DialogResult.OK;
			Close();
		}

		private void BtnAddPageClick(object sender, EventArgs e)
		{
			using (var form = new PageEditorForm())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					config.Pages.Add(form.Page);
					lbPages.DataSource = config.Pages;
				}
			}
		}

		private void BtnEditPageClick(object sender, EventArgs e)
		{
			var page = lbPages.SelectedItem as NooliteControlPage;
			if (page != null)
			{
				using (var form = new PageEditorForm(page))
				{
					if (form.ShowDialog() == DialogResult.OK)
					{
						lbPages.DataSource = config.Pages;
					}
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var page = lbPages.SelectedItem as NooliteControlPage;
			if (page != null)
			{
				var confirmation = MessageBox.Show(
					"Раздел будет удален. Продолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

				if (confirmation == DialogResult.Yes)
				{
					config.Pages.Remove(page);
				}
			}
		}

		private void btnUp_Click(object sender, EventArgs e)
		{
			var index = lbPages.SelectedIndex;

			if (index > 0)
			{
				var page = config.Pages[index];
				config.Pages.RemoveAt(index);
				config.Pages.Insert(index - 1, page);

				lbPages.SelectedIndex = index - 1;
			}
		}

		private void btnDown_Click(object sender, EventArgs e)
		{
			var index = lbPages.SelectedIndex;

			if (index >= 0 && index < config.Pages.Count - 1)
			{
				var page = config.Pages[index];
				config.Pages.RemoveAt(index);
				config.Pages.Insert(index + 1, page);

				lbPages.SelectedIndex = index + 1;
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK)
			{
				var confirmation = MessageBox.Show("Выйти без сохранения изменений?", "Внимание!", MessageBoxButtons.YesNo,
												   MessageBoxIcon.Exclamation);
				e.Cancel = confirmation == DialogResult.No;
			}
		}
	}
}
