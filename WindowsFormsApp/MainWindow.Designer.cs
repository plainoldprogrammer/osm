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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxSnippetTitle = new System.Windows.Forms.TextBox();
            listBoxCategories = new System.Windows.Forms.ListBox();
            listBoxSnippets = new System.Windows.Forms.ListBox();
            buttonNewCategory = new System.Windows.Forms.Button();
            buttonRemoveCategory = new System.Windows.Forms.Button();
            buttonNewSnippet = new System.Windows.Forms.Button();
            buttonRemoveSnippet = new System.Windows.Forms.Button();
            menuStrip = new System.Windows.Forms.MenuStrip();
            richTextBoxSnippetContent = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Categories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(261, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Snippets";
            // 
            // textBoxSnippetTitle
            // 
            textBoxSnippetTitle.Location = new System.Drawing.Point(514, 31);
            textBoxSnippetTitle.Name = "textBoxSnippetTitle";
            textBoxSnippetTitle.Size = new System.Drawing.Size(514, 23);
            textBoxSnippetTitle.TabIndex = 9;
            textBoxSnippetTitle.TextChanged += textBoxSnippetTitle_TextChanged;
            // 
            // listBoxCategories
            // 
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.ItemHeight = 15;
            listBoxCategories.Location = new System.Drawing.Point(8, 57);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new System.Drawing.Size(247, 484);
            listBoxCategories.TabIndex = 3;
            listBoxCategories.SelectedValueChanged += listBoxCategories_SelectedValueChanged;
            // 
            // listBoxSnippets
            // 
            listBoxSnippets.FormattingEnabled = true;
            listBoxSnippets.ItemHeight = 15;
            listBoxSnippets.Location = new System.Drawing.Point(261, 57);
            listBoxSnippets.Name = "listBoxSnippets";
            listBoxSnippets.Size = new System.Drawing.Size(247, 484);
            listBoxSnippets.TabIndex = 4;
            listBoxSnippets.SelectedValueChanged += listBoxSnippets_SelectedValueChanged;
            // 
            // buttonNewCategory
            // 
            buttonNewCategory.Location = new System.Drawing.Point(8, 557);
            buttonNewCategory.Name = "buttonNewCategory";
            buttonNewCategory.Size = new System.Drawing.Size(120, 23);
            buttonNewCategory.TabIndex = 5;
            buttonNewCategory.Text = "New Category";
            buttonNewCategory.UseVisualStyleBackColor = true;
            buttonNewCategory.Click += buttonNewCategory_Click;
            // 
            // buttonRemoveCategory
            // 
            buttonRemoveCategory.Location = new System.Drawing.Point(136, 557);
            buttonRemoveCategory.Name = "buttonRemoveCategory";
            buttonRemoveCategory.Size = new System.Drawing.Size(120, 23);
            buttonRemoveCategory.TabIndex = 6;
            buttonRemoveCategory.Text = "Remove Category";
            buttonRemoveCategory.UseVisualStyleBackColor = true;
            buttonRemoveCategory.Click += buttonRemoveCategory_Click;
            // 
            // buttonNewSnippet
            // 
            buttonNewSnippet.Location = new System.Drawing.Point(261, 557);
            buttonNewSnippet.Name = "buttonNewSnippet";
            buttonNewSnippet.Size = new System.Drawing.Size(120, 23);
            buttonNewSnippet.TabIndex = 7;
            buttonNewSnippet.Text = "New Snippet";
            buttonNewSnippet.UseVisualStyleBackColor = true;
            buttonNewSnippet.Click += buttonNewSnippet_Click;
            // 
            // buttonRemoveSnippet
            // 
            buttonRemoveSnippet.Location = new System.Drawing.Point(388, 557);
            buttonRemoveSnippet.Name = "buttonRemoveSnippet";
            buttonRemoveSnippet.Size = new System.Drawing.Size(120, 23);
            buttonRemoveSnippet.TabIndex = 8;
            buttonRemoveSnippet.Text = "Remove Snippet";
            buttonRemoveSnippet.UseVisualStyleBackColor = true;
            buttonRemoveSnippet.Click += buttonRemoveSnippet_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(1040, 24);
            menuStrip.TabIndex = 12;
            menuStrip.Text = "menuStrip";
            // 
            // richTextBoxSnippetContent
            // 
            richTextBoxSnippetContent.Location = new System.Drawing.Point(514, 57);
            richTextBoxSnippetContent.Name = "richTextBoxSnippetContent";
            richTextBoxSnippetContent.Size = new System.Drawing.Size(514, 484);
            richTextBoxSnippetContent.TabIndex = 13;
            richTextBoxSnippetContent.Text = "";
            richTextBoxSnippetContent.TextChanged += richTextBoxSnippetContent_TextChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1040, 592);
            Controls.Add(richTextBoxSnippetContent);
            Controls.Add(buttonRemoveSnippet);
            Controls.Add(buttonNewSnippet);
            Controls.Add(buttonRemoveCategory);
            Controls.Add(buttonNewCategory);
            Controls.Add(listBoxSnippets);
            Controls.Add(listBoxCategories);
            Controls.Add(textBoxSnippetTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSnippetTitle;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.ListBox listBoxSnippets;
        private System.Windows.Forms.Button buttonNewCategory;
        private System.Windows.Forms.Button buttonRemoveCategory;
        private System.Windows.Forms.Button buttonNewSnippet;
        private System.Windows.Forms.Button buttonRemoveSnippet;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.RichTextBox richTextBoxSnippetContent;
    }
}
