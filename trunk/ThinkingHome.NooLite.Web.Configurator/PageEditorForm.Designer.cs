namespace ThinkingHome.NooLite.Web.Configurator
{
	partial class PageEditorForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbIdentifier = new System.Windows.Forms.TextBox();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEditPage = new System.Windows.Forms.Button();
			this.btnAddPage = new System.Windows.Forms.Button();
			this.lbControls = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Идентификатор";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Заголовок";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Пояснение";
			// 
			// tbIdentifier
			// 
			this.tbIdentifier.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.tbIdentifier.Location = new System.Drawing.Point(105, 12);
			this.tbIdentifier.Name = "tbIdentifier";
			this.tbIdentifier.Size = new System.Drawing.Size(132, 20);
			this.tbIdentifier.TabIndex = 3;
			this.tbIdentifier.Validating += new System.ComponentModel.CancelEventHandler(this.TbIdentifierValidating);
			// 
			// tbTitle
			// 
			this.tbTitle.Location = new System.Drawing.Point(105, 38);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(209, 20);
			this.tbTitle.TabIndex = 4;
			// 
			// tbDescription
			// 
			this.tbDescription.Location = new System.Drawing.Point(105, 64);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(209, 20);
			this.tbDescription.TabIndex = 5;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(187, 253);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(88, 23);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(281, 253);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(88, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbControls);
			this.groupBox1.Controls.Add(this.btnUp);
			this.groupBox1.Controls.Add(this.btnDown);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnEditPage);
			this.groupBox1.Controls.Add(this.btnAddPage);
			this.groupBox1.Location = new System.Drawing.Point(12, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(357, 157);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Элементы управления";
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(269, 19);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(38, 23);
			this.btnUp.TabIndex = 14;
			this.btnUp.Text = "↑";
			this.btnUp.UseVisualStyleBackColor = true;
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(313, 19);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(38, 23);
			this.btnDown.TabIndex = 15;
			this.btnDown.Text = "↓";
			this.btnDown.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(168, 19);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnEditPage
			// 
			this.btnEditPage.Location = new System.Drawing.Point(87, 19);
			this.btnEditPage.Name = "btnEditPage";
			this.btnEditPage.Size = new System.Drawing.Size(75, 23);
			this.btnEditPage.TabIndex = 17;
			this.btnEditPage.Text = "Изменить";
			this.btnEditPage.UseVisualStyleBackColor = true;
			// 
			// btnAddPage
			// 
			this.btnAddPage.Location = new System.Drawing.Point(6, 19);
			this.btnAddPage.Name = "btnAddPage";
			this.btnAddPage.Size = new System.Drawing.Size(75, 23);
			this.btnAddPage.TabIndex = 16;
			this.btnAddPage.Text = "Добавить";
			this.btnAddPage.UseVisualStyleBackColor = true;
			// 
			// lbControls
			// 
			this.lbControls.DisplayMember = "ConfiguratorUiDisplayText";
			this.lbControls.FormattingEnabled = true;
			this.lbControls.Location = new System.Drawing.Point(6, 48);
			this.lbControls.Name = "lbControls";
			this.lbControls.Size = new System.Drawing.Size(345, 95);
			this.lbControls.TabIndex = 9;
			// 
			// PageEditorForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(381, 288);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.tbTitle);
			this.Controls.Add(this.tbIdentifier);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PageEditorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Редактор разделов";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbIdentifier;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEditPage;
		private System.Windows.Forms.Button btnAddPage;
		private System.Windows.Forms.ListBox lbControls;
	}
}