namespace ThinkingHome.NooLite.Web.Configurator
{
	partial class ChannelActionEditorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ddlChannelIds = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblLevel = new System.Windows.Forms.Label();
			this.trbLevel = new System.Windows.Forms.TrackBar();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbSpecificLevel = new System.Windows.Forms.CheckBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.trbLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// ddlChannelIds
			// 
			this.ddlChannelIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlChannelIds.FormattingEnabled = true;
			this.ddlChannelIds.Location = new System.Drawing.Point(68, 12);
			this.ddlChannelIds.Name = "ddlChannelIds";
			this.ddlChannelIds.Size = new System.Drawing.Size(46, 21);
			this.ddlChannelIds.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Канал";
			// 
			// lblLevel
			// 
			this.lblLevel.AutoSize = true;
			this.lblLevel.Location = new System.Drawing.Point(12, 39);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new System.Drawing.Size(50, 13);
			this.lblLevel.TabIndex = 2;
			this.lblLevel.Text = "Яркость";
			// 
			// trbLevel
			// 
			this.trbLevel.Location = new System.Drawing.Point(68, 39);
			this.trbLevel.Name = "trbLevel";
			this.trbLevel.Size = new System.Drawing.Size(233, 45);
			this.trbLevel.TabIndex = 3;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(213, 92);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(88, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(119, 92);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(88, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cbSpecificLevel
			// 
			this.cbSpecificLevel.AutoSize = true;
			this.cbSpecificLevel.Location = new System.Drawing.Point(144, 14);
			this.cbSpecificLevel.Name = "cbSpecificLevel";
			this.cbSpecificLevel.Size = new System.Drawing.Size(157, 17);
			this.cbSpecificLevel.TabIndex = 6;
			this.cbSpecificLevel.Text = "Указать уровень яркости";
			this.cbSpecificLevel.UseVisualStyleBackColor = true;
			this.cbSpecificLevel.CheckedChanged += new System.EventHandler(this.cbSpecificLevel_CheckedChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ChannelActionEditorForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(313, 127);
			this.Controls.Add(this.cbSpecificLevel);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.trbLevel);
			this.Controls.Add(this.lblLevel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ddlChannelIds);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChannelActionEditorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Яркость в канале";
			((System.ComponentModel.ISupportInitialize)(this.trbLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox ddlChannelIds;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblLevel;
		private System.Windows.Forms.TrackBar trbLevel;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox cbSpecificLevel;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}