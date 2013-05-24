using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

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
			Close();
		}

		private void BtnAddPageClick(object sender, EventArgs e)
		{
			using (var form = new PageEditorForm())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
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
	}
}
