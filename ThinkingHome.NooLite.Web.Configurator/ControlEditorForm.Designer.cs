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
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// tbTitle
			// 
			this.tbTitle.Location = new System.Drawing.Point(108, 38);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(209, 20);
			this.tbTitle.TabIndex = 8;
			// 
			// tbIdentifier
			// 
			this.tbIdentifier.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.tbIdentifier.Location = new System.Drawing.Point(108, 12);
			this.tbIdentifier.Name = "tbIdentifier";
			this.tbIdentifier.Size = new System.Drawing.Size(132, 20);
			this.tbIdentifier.TabIndex = 7;
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
			this.ddlControlType.Location = new System.Drawing.Point(108, 64);
			this.ddlControlType.Name = "ddlControlType";
			this.ddlControlType.Size = new System.Drawing.Size(132, 21);
			this.ddlControlType.TabIndex = 9;
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
			// ControlEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 262);
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
	}
}