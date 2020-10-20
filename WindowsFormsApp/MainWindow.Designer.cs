namespace WindowsFormsApp
{
    partial class MainWindow
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
            this.buttonNewCategory = new System.Windows.Forms.Button();
            this.buttonRemoveCategory = new System.Windows.Forms.Button();
            this.buttonNewSnippet = new System.Windows.Forms.Button();
            this.buttonRemoveSnippet = new System.Windows.Forms.Button();
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
            // buttonNewCategory
            // 
            this.buttonNewCategory.Location = new System.Drawing.Point(8, 557);
            this.buttonNewCategory.Name = "buttonNewCategory";
            this.buttonNewCategory.Size = new System.Drawing.Size(120, 23);
            this.buttonNewCategory.TabIndex = 8;
            this.buttonNewCategory.Text = "New Category";
            this.buttonNewCategory.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveCategory
            // 
            this.buttonRemoveCategory.Location = new System.Drawing.Point(135, 556);
            this.buttonRemoveCategory.Name = "buttonRemoveCategory";
            this.buttonRemoveCategory.Size = new System.Drawing.Size(120, 23);
            this.buttonRemoveCategory.TabIndex = 9;
            this.buttonRemoveCategory.Text = "Remove Category";
            this.buttonRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // buttonNewSnippet
            // 
            this.buttonNewSnippet.Location = new System.Drawing.Point(261, 557);
            this.buttonNewSnippet.Name = "buttonNewSnippet";
            this.buttonNewSnippet.Size = new System.Drawing.Size(120, 23);
            this.buttonNewSnippet.TabIndex = 10;
            this.buttonNewSnippet.Text = "New Snippet";
            this.buttonNewSnippet.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveSnippet
            // 
            this.buttonRemoveSnippet.Location = new System.Drawing.Point(389, 556);
            this.buttonRemoveSnippet.Name = "buttonRemoveSnippet";
            this.buttonRemoveSnippet.Size = new System.Drawing.Size(120, 23);
            this.buttonRemoveSnippet.TabIndex = 11;
            this.buttonRemoveSnippet.Text = "Remove Snippet";
            this.buttonRemoveSnippet.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 592);
            this.Controls.Add(this.buttonRemoveSnippet);
            this.Controls.Add(this.buttonNewSnippet);
            this.Controls.Add(this.buttonRemoveCategory);
            this.Controls.Add(this.buttonNewCategory);
            this.Controls.Add(this.listBoxSnippets);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.textBoxSnippetTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSnippetContent);
            this.Name = "MainWindow";
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
        private System.Windows.Forms.ListBox listBoxSnippets;
        private System.Windows.Forms.Button buttonNewCategory;
        private System.Windows.Forms.Button buttonRemoveCategory;
        private System.Windows.Forms.Button buttonNewSnippet;
        private System.Windows.Forms.Button buttonRemoveSnippet;
    }
}
