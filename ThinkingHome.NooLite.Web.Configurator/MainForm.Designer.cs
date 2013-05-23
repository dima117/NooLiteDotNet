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
			this.button3 = new System.Windows.Forms.Button();
			this.btnEditPage = new System.Windows.Forms.Button();
			this.btnAddPage = new System.Windows.Forms.Button();
			this.lbPages = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(205, 259);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(286, 259);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
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
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.btnEditPage);
			this.groupBox1.Controls.Add(this.btnAddPage);
			this.groupBox1.Controls.Add(this.lbPages);
			this.groupBox1.Location = new System.Drawing.Point(12, 61);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(349, 192);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Разделы";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(168, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "Удалить";
			this.button3.UseVisualStyleBackColor = true;
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
			this.lbPages.FormattingEnabled = true;
			this.lbPages.Location = new System.Drawing.Point(6, 44);
			this.lbPages.Name = "lbPages";
			this.lbPages.Size = new System.Drawing.Size(337, 134);
			this.lbPages.TabIndex = 10;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 294);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbDebug);
			this.Controls.Add(this.tbTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Form1";
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
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnEditPage;
		private System.Windows.Forms.Button btnAddPage;
		private System.Windows.Forms.ListBox lbPages;


	}
}

