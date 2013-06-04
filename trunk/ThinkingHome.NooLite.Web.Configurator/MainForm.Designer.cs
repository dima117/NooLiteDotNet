namespace ThinkingHome.NooLite.Web.Configurator
{
	partial class MainForm
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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.cbDebug = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEditPage = new System.Windows.Forms.Button();
			this.btnAddPage = new System.Windows.Forms.Button();
			this.lbPages = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(197, 259);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(88, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(291, 259);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(88, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Заголовок";
			// 
			// tbTitle
			// 
			this.tbTitle.Location = new System.Drawing.Point(79, 12);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(214, 20);
			this.tbTitle.TabIndex = 3;
			// 
			// cbDebug
			// 
			this.cbDebug.AutoSize = true;
			this.cbDebug.Location = new System.Drawing.Point(79, 38);
			this.cbDebug.Name = "cbDebug";
			this.cbDebug.Size = new System.Drawing.Size(105, 17);
			this.cbDebug.TabIndex = 4;
			this.cbDebug.Text = "Режим отладки";
			this.cbDebug.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnUp);
			this.groupBox1.Controls.Add(this.btnDown);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnEditPage);
			this.groupBox1.Controls.Add(this.btnAddPage);
			this.groupBox1.Controls.Add(this.lbPages);
			this.groupBox1.Location = new System.Drawing.Point(12, 61);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(367, 192);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Разделы";
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(279, 19);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(38, 23);
			this.btnUp.TabIndex = 6;
			this.btnUp.Text = "↑";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(323, 19);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(38, 23);
			this.btnDown.TabIndex = 7;
			this.btnDown.Text = "↓";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(168, 19);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEditPage
			// 
			this.btnEditPage.Location = new System.Drawing.Point(87, 19);
			this.btnEditPage.Name = "btnEditPage";
			this.btnEditPage.Size = new System.Drawing.Size(75, 23);
			this.btnEditPage.TabIndex = 12;
			this.btnEditPage.Text = "Изменить";
			this.btnEditPage.UseVisualStyleBackColor = true;
			this.btnEditPage.Click += new System.EventHandler(this.BtnEditPageClick);
			// 
			// btnAddPage
			// 
			this.btnAddPage.Location = new System.Drawing.Point(6, 19);
			this.btnAddPage.Name = "btnAddPage";
			this.btnAddPage.Size = new System.Drawing.Size(75, 23);
			this.btnAddPage.TabIndex = 11;
			this.btnAddPage.Text = "Добавить";
			this.btnAddPage.UseVisualStyleBackColor = true;
			this.btnAddPage.Click += new System.EventHandler(this.BtnAddPageClick);
			// 
			// lbPages
			// 
			this.lbPages.DisplayMember = "Title";
			this.lbPages.FormattingEnabled = true;
			this.lbPages.Location = new System.Drawing.Point(6, 48);
			this.lbPages.Name = "lbPages";
			this.lbPages.Size = new System.Drawing.Size(355, 134);
			this.lbPages.TabIndex = 10;
			this.lbPages.DoubleClick += new System.EventHandler(this.BtnEditPageClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(391, 294);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbDebug);
			this.Controls.Add(this.tbTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактирование конфигурации";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.CheckBox cbDebug;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEditPage;
		private System.Windows.Forms.Button btnAddPage;
		private System.Windows.Forms.ListBox lbPages;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;


	}
}

