namespace WindowsFormsApp
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.snippetsCategories = new System.Windows.Forms.TextBox();
            this.snippetsTitles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // snippetsCategories
            // 
            this.snippetsCategories.Location = new System.Drawing.Point(8, 57);
            this.snippetsCategories.Multiline = true;
            this.snippetsCategories.Name = "snippetsCategories";
            this.snippetsCategories.Size = new System.Drawing.Size(247, 474);
            this.snippetsCategories.TabIndex = 0;
            this.snippetsCategories.WordWrap = false;
            this.snippetsCategories.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // snippetsTitles
            // 
            this.snippetsTitles.Location = new System.Drawing.Point(261, 57);
            this.snippetsTitles.Multiline = true;
            this.snippetsTitles.Name = "snippetsTitles";
            this.snippetsTitles.Size = new System.Drawing.Size(247, 474);
            this.snippetsTitles.TabIndex = 1;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 585);
            this.Controls.Add(this.snippetsTitles);
            this.Controls.Add(this.snippetsCategories);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox snippetsCategories;
        private System.Windows.Forms.TextBox snippetsTitles;
    }
}
