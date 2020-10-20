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
            this.textBoxSnippetContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSnippetTitle = new System.Windows.Forms.TextBox();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.listBoxSnippets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxSnippetContent
            // 
            this.textBoxSnippetContent.Location = new System.Drawing.Point(514, 57);
            this.textBoxSnippetContent.Multiline = true;
            this.textBoxSnippetContent.Name = "textBoxSnippetContent";
            this.textBoxSnippetContent.Size = new System.Drawing.Size(514, 484);
            this.textBoxSnippetContent.TabIndex = 2;
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
            // textBoxSnippetTitle
            // 
            this.textBoxSnippetTitle.Location = new System.Drawing.Point(514, 31);
            this.textBoxSnippetTitle.Name = "textBoxSnippetTitle";
            this.textBoxSnippetTitle.Size = new System.Drawing.Size(514, 23);
            this.textBoxSnippetTitle.TabIndex = 5;
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 15;
            this.listBoxCategories.Location = new System.Drawing.Point(8, 57);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(247, 484);
            this.listBoxCategories.TabIndex = 6;
            // 
            // listBoxSnippets
            // 
            this.listBoxSnippets.FormattingEnabled = true;
            this.listBoxSnippets.ItemHeight = 15;
            this.listBoxSnippets.Location = new System.Drawing.Point(261, 57);
            this.listBoxSnippets.Name = "listBoxSnippets";
            this.listBoxSnippets.Size = new System.Drawing.Size(247, 484);
            this.listBoxSnippets.TabIndex = 7;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 592);
            this.Controls.Add(this.listBoxSnippets);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.textBoxSnippetTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSnippetContent);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSnippetContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSnippetTitle;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBoxSnippets;
    }
}
