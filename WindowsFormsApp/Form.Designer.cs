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
            this.snippetContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // snippetContent
            // 
            this.snippetContent.Location = new System.Drawing.Point(514, 57);
            this.snippetContent.Multiline = true;
            this.snippetContent.Name = "snippetContent";
            this.snippetContent.Size = new System.Drawing.Size(514, 474);
            this.snippetContent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Snippets";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(514, 23);
            this.textBox1.TabIndex = 5;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 585);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.snippetContent);
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
        private System.Windows.Forms.TextBox snippetContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
