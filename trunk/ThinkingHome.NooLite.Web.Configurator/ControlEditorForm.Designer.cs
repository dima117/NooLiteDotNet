namespace ThinkingHome.NooLite.Web.Configurator
{
	partial class ControlEditorForm
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
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.tbIdentifier = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ddlControlType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.trbDefaultLevel = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trbDefaultLevel)).BeginInit();
			this.SuspendLayout();
			// 
			// tbTitle
			// 
			this.tbTitle.Location = new System.Drawing.Point(142, 38);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(209, 20);
			this.tbTitle.TabIndex = 20;
			// 
			// tbIdentifier
			// 
			this.tbIdentifier.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.tbIdentifier.Location = new System.Drawing.Point(142, 15);
			this.tbIdentifier.Name = "tbIdentifier";
			this.tbIdentifier.Size = new System.Drawing.Size(132, 20);
			this.tbIdentifier.TabIndex = 10;
			this.tbIdentifier.Validating += new System.ComponentModel.CancelEventHandler(this.TbIdentifierValidating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Заголовок";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Идентификатор";
			// 
			// ddlControlType
			// 
			this.ddlControlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlControlType.FormattingEnabled = true;
			this.ddlControlType.Items.AddRange(new object[] {
            "Button",
            "Switcher",
            "Slider"});
			this.ddlControlType.Location = new System.Drawing.Point(142, 64);
			this.ddlControlType.Name = "ddlControlType";
			this.ddlControlType.Size = new System.Drawing.Size(132, 21);
			this.ddlControlType.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Тип элемента";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(339, 227);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 260;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(258, 227);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 250;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Яркость по умолчанию";
			// 
			// trbDefaultLevel
			// 
			this.trbDefaultLevel.Location = new System.Drawing.Point(142, 91);
			this.trbDefaultLevel.Name = "trbDefaultLevel";
			this.trbDefaultLevel.Size = new System.Drawing.Size(209, 45);
			this.trbDefaultLevel.SmallChange = 10;
			this.trbDefaultLevel.TabIndex = 40;
			// 
			// ControlEditorForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(426, 262);
			this.Controls.Add(this.trbDefaultLevel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ddlControlType);
			this.Controls.Add(this.tbTitle);
			this.Controls.Add(this.tbIdentifier);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ControlEditorForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Редактор элемента управления";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trbDefaultLevel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.TextBox tbIdentifier;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ddlControlType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TrackBar trbDefaultLevel;
		private System.Windows.Forms.Label label4;
	}
}