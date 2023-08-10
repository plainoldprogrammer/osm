namespace Osm
{
	partial class OptionsWindow
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
			labelDbFile = new System.Windows.Forms.Label();
			textBoxDbFile = new System.Windows.Forms.TextBox();
			buttonSelectDbFile = new System.Windows.Forms.Button();
			labelTheme = new System.Windows.Forms.Label();
			comboBoxTheme = new System.Windows.Forms.ComboBox();
			labelFont = new System.Windows.Forms.Label();
			labelFontSize = new System.Windows.Forms.Label();
			comboBoxFontSize = new System.Windows.Forms.ComboBox();
			checkBoxWordWrap = new System.Windows.Forms.CheckBox();
			buttonOk = new System.Windows.Forms.Button();
			buttonCancel = new System.Windows.Forms.Button();
			comboBoxFont = new System.Windows.Forms.ComboBox();
			SuspendLayout();
			// 
			// labelDbFile
			// 
			labelDbFile.AutoSize = true;
			labelDbFile.Location = new System.Drawing.Point(14, 31);
			labelDbFile.Name = "labelDbFile";
			labelDbFile.Size = new System.Drawing.Size(59, 20);
			labelDbFile.TabIndex = 0;
			labelDbFile.Text = "DB File:";
			// 
			// textBoxDbFile
			// 
			textBoxDbFile.Location = new System.Drawing.Point(73, 27);
			textBoxDbFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			textBoxDbFile.Name = "textBoxDbFile";
			textBoxDbFile.Size = new System.Drawing.Size(338, 27);
			textBoxDbFile.TabIndex = 1;
			// 
			// buttonSelectDbFile
			// 
			buttonSelectDbFile.Location = new System.Drawing.Point(418, 27);
			buttonSelectDbFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			buttonSelectDbFile.Name = "buttonSelectDbFile";
			buttonSelectDbFile.Size = new System.Drawing.Size(59, 31);
			buttonSelectDbFile.TabIndex = 2;
			buttonSelectDbFile.Text = "...";
			buttonSelectDbFile.UseVisualStyleBackColor = true;
			buttonSelectDbFile.Click += buttonSelectDbFile_Click;
			// 
			// labelTheme
			// 
			labelTheme.AutoSize = true;
			labelTheme.Location = new System.Drawing.Point(14, 95);
			labelTheme.Name = "labelTheme";
			labelTheme.Size = new System.Drawing.Size(57, 20);
			labelTheme.TabIndex = 3;
			labelTheme.Text = "Theme:";
			// 
			// comboBoxTheme
			// 
			comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxTheme.FormattingEnabled = true;
			comboBoxTheme.Items.AddRange(new object[] { "Light", "Dark" });
			comboBoxTheme.Location = new System.Drawing.Point(14, 119);
			comboBoxTheme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			comboBoxTheme.Name = "comboBoxTheme";
			comboBoxTheme.Size = new System.Drawing.Size(138, 28);
			comboBoxTheme.TabIndex = 4;
			// 
			// labelFont
			// 
			labelFont.AutoSize = true;
			labelFont.Location = new System.Drawing.Point(14, 171);
			labelFont.Name = "labelFont";
			labelFont.Size = new System.Drawing.Size(41, 20);
			labelFont.TabIndex = 5;
			labelFont.Text = "Font:";
			// 
			// labelFontSize
			// 
			labelFontSize.AutoSize = true;
			labelFontSize.Location = new System.Drawing.Point(263, 171);
			labelFontSize.Name = "labelFontSize";
			labelFontSize.Size = new System.Drawing.Size(39, 20);
			labelFontSize.TabIndex = 7;
			labelFontSize.Text = "Size:";
			// 
			// comboBoxFontSize
			// 
			comboBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxFontSize.FormattingEnabled = true;
			comboBoxFontSize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
			comboBoxFontSize.Location = new System.Drawing.Point(263, 195);
			comboBoxFontSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			comboBoxFontSize.Name = "comboBoxFontSize";
			comboBoxFontSize.Size = new System.Drawing.Size(81, 28);
			comboBoxFontSize.TabIndex = 8;
			// 
			// checkBoxWordWrap
			// 
			checkBoxWordWrap.AutoSize = true;
			checkBoxWordWrap.Location = new System.Drawing.Point(368, 197);
			checkBoxWordWrap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			checkBoxWordWrap.Name = "checkBoxWordWrap";
			checkBoxWordWrap.Size = new System.Drawing.Size(107, 24);
			checkBoxWordWrap.TabIndex = 9;
			checkBoxWordWrap.Text = "Word Wrap";
			checkBoxWordWrap.UseVisualStyleBackColor = true;
			checkBoxWordWrap.CheckedChanged += checkBoxWordWrap_CheckedChanged;
			// 
			// buttonOk
			// 
			buttonOk.Location = new System.Drawing.Point(293, 375);
			buttonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			buttonOk.Name = "buttonOk";
			buttonOk.Size = new System.Drawing.Size(86, 31);
			buttonOk.TabIndex = 10;
			buttonOk.Text = "Ok";
			buttonOk.UseVisualStyleBackColor = true;
			buttonOk.Click += buttonOk_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Location = new System.Drawing.Point(391, 375);
			buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new System.Drawing.Size(86, 31);
			buttonCancel.TabIndex = 11;
			buttonCancel.Text = "Cancel";
			buttonCancel.UseVisualStyleBackColor = true;
			buttonCancel.Click += buttonCancel_Click;
			// 
			// comboBoxFont
			// 
			comboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxFont.FormattingEnabled = true;
			comboBoxFont.Location = new System.Drawing.Point(14, 195);
			comboBoxFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			comboBoxFont.Name = "comboBoxFont";
			comboBoxFont.Size = new System.Drawing.Size(231, 28);
			comboBoxFont.TabIndex = 12;
			// 
			// OptionsWindow
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(491, 439);
			Controls.Add(comboBoxFont);
			Controls.Add(buttonCancel);
			Controls.Add(buttonOk);
			Controls.Add(checkBoxWordWrap);
			Controls.Add(comboBoxFontSize);
			Controls.Add(labelFontSize);
			Controls.Add(labelFont);
			Controls.Add(comboBoxTheme);
			Controls.Add(labelTheme);
			Controls.Add(buttonSelectDbFile);
			Controls.Add(textBoxDbFile);
			Controls.Add(labelDbFile);
			Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			Name = "OptionsWindow";
			Text = "Options";
			FormClosing += OptionsWindow_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label labelDbFile;
		private System.Windows.Forms.TextBox textBoxDbFile;
		private System.Windows.Forms.Button buttonSelectDbFile;
		private System.Windows.Forms.Label labelTheme;
		private System.Windows.Forms.ComboBox comboBoxTheme;
		private System.Windows.Forms.Label labelFont;
		private System.Windows.Forms.Label labelFontSize;
		private System.Windows.Forms.ComboBox comboBoxFontSize;
		private System.Windows.Forms.CheckBox checkBoxWordWrap;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ComboBox comboBoxFont;
	}
}