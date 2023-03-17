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
            textBoxFont = new System.Windows.Forms.TextBox();
            labelFontSize = new System.Windows.Forms.Label();
            comboBoxFontSize = new System.Windows.Forms.ComboBox();
            checkBoxWordWrap = new System.Windows.Forms.CheckBox();
            buttonOk = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelDbFile
            // 
            labelDbFile.AutoSize = true;
            labelDbFile.Location = new System.Drawing.Point(12, 23);
            labelDbFile.Name = "labelDbFile";
            labelDbFile.Size = new System.Drawing.Size(46, 15);
            labelDbFile.TabIndex = 0;
            labelDbFile.Text = "DB File:";
            // 
            // textBoxDbFile
            // 
            textBoxDbFile.Location = new System.Drawing.Point(64, 20);
            textBoxDbFile.Name = "textBoxDbFile";
            textBoxDbFile.Size = new System.Drawing.Size(296, 23);
            textBoxDbFile.TabIndex = 1;
            // 
            // buttonSelectDbFile
            // 
            buttonSelectDbFile.Location = new System.Drawing.Point(366, 20);
            buttonSelectDbFile.Name = "buttonSelectDbFile";
            buttonSelectDbFile.Size = new System.Drawing.Size(52, 23);
            buttonSelectDbFile.TabIndex = 2;
            buttonSelectDbFile.Text = "...";
            buttonSelectDbFile.UseVisualStyleBackColor = true;
            // 
            // labelTheme
            // 
            labelTheme.AutoSize = true;
            labelTheme.Location = new System.Drawing.Point(12, 71);
            labelTheme.Name = "labelTheme";
            labelTheme.Size = new System.Drawing.Size(46, 15);
            labelTheme.TabIndex = 3;
            labelTheme.Text = "Theme:";
            // 
            // comboBoxTheme
            // 
            comboBoxTheme.FormattingEnabled = true;
            comboBoxTheme.Location = new System.Drawing.Point(12, 89);
            comboBoxTheme.Name = "comboBoxTheme";
            comboBoxTheme.Size = new System.Drawing.Size(121, 23);
            comboBoxTheme.TabIndex = 4;
            // 
            // labelFont
            // 
            labelFont.AutoSize = true;
            labelFont.Location = new System.Drawing.Point(12, 128);
            labelFont.Name = "labelFont";
            labelFont.Size = new System.Drawing.Size(34, 15);
            labelFont.TabIndex = 5;
            labelFont.Text = "Font:";
            // 
            // textBoxFont
            // 
            textBoxFont.Location = new System.Drawing.Point(12, 146);
            textBoxFont.Name = "textBoxFont";
            textBoxFont.Size = new System.Drawing.Size(188, 23);
            textBoxFont.TabIndex = 6;
            // 
            // labelFontSize
            // 
            labelFontSize.AutoSize = true;
            labelFontSize.Location = new System.Drawing.Point(230, 128);
            labelFontSize.Name = "labelFontSize";
            labelFontSize.Size = new System.Drawing.Size(30, 15);
            labelFontSize.TabIndex = 7;
            labelFontSize.Text = "Size:";
            // 
            // comboBoxFontSize
            // 
            comboBoxFontSize.FormattingEnabled = true;
            comboBoxFontSize.Location = new System.Drawing.Point(230, 146);
            comboBoxFontSize.Name = "comboBoxFontSize";
            comboBoxFontSize.Size = new System.Drawing.Size(71, 23);
            comboBoxFontSize.TabIndex = 8;
            // 
            // checkBoxWordWrap
            // 
            checkBoxWordWrap.AutoSize = true;
            checkBoxWordWrap.Location = new System.Drawing.Point(322, 148);
            checkBoxWordWrap.Name = "checkBoxWordWrap";
            checkBoxWordWrap.Size = new System.Drawing.Size(86, 19);
            checkBoxWordWrap.TabIndex = 9;
            checkBoxWordWrap.Text = "Word Wrap";
            checkBoxWordWrap.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.Location = new System.Drawing.Point(256, 281);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new System.Drawing.Size(75, 23);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(342, 281);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // OptionsWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 329);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(checkBoxWordWrap);
            Controls.Add(comboBoxFontSize);
            Controls.Add(labelFontSize);
            Controls.Add(textBoxFont);
            Controls.Add(labelFont);
            Controls.Add(comboBoxTheme);
            Controls.Add(labelTheme);
            Controls.Add(buttonSelectDbFile);
            Controls.Add(textBoxDbFile);
            Controls.Add(labelDbFile);
            Name = "OptionsWindow";
            Text = "Options";
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
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
        private System.Windows.Forms.CheckBox checkBoxWordWrap;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}