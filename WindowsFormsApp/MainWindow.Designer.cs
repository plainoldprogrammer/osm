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
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            richTextBoxSnippetContent = new System.Windows.Forms.RichTextBox();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(10, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Categories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(239, 31);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Snippets";
            // 
            // textBoxSnippetTitle
            // 
            textBoxSnippetTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxSnippetTitle.Location = new System.Drawing.Point(471, 26);
            textBoxSnippetTitle.Name = "textBoxSnippetTitle";
            textBoxSnippetTitle.Size = new System.Drawing.Size(442, 23);
            textBoxSnippetTitle.TabIndex = 9;
            textBoxSnippetTitle.TextChanged += textBoxSnippetTitle_TextChanged;
            // 
            // listBoxCategories
            // 
            listBoxCategories.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.ItemHeight = 15;
            listBoxCategories.Location = new System.Drawing.Point(10, 52);
            listBoxCategories.MinimumSize = new System.Drawing.Size(224, 334);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new System.Drawing.Size(224, 334);
            listBoxCategories.TabIndex = 3;
            listBoxCategories.SelectedValueChanged += listBoxCategories_SelectedValueChanged;
            // 
            // listBoxSnippets
            // 
            listBoxSnippets.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            listBoxSnippets.FormattingEnabled = true;
            listBoxSnippets.ItemHeight = 15;
            listBoxSnippets.Location = new System.Drawing.Point(239, 52);
            listBoxSnippets.MinimumSize = new System.Drawing.Size(224, 334);
            listBoxSnippets.Name = "listBoxSnippets";
            listBoxSnippets.Size = new System.Drawing.Size(224, 334);
            listBoxSnippets.TabIndex = 4;
            listBoxSnippets.SelectedValueChanged += listBoxSnippets_SelectedValueChanged;
            // 
            // buttonNewCategory
            // 
            buttonNewCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonNewCategory.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonNewCategory.Location = new System.Drawing.Point(10, 394);
            buttonNewCategory.MaximumSize = new System.Drawing.Size(110, 23);
            buttonNewCategory.MinimumSize = new System.Drawing.Size(110, 23);
            buttonNewCategory.Name = "buttonNewCategory";
            buttonNewCategory.Size = new System.Drawing.Size(110, 23);
            buttonNewCategory.TabIndex = 5;
            buttonNewCategory.Text = "New Category";
            buttonNewCategory.UseVisualStyleBackColor = true;
            buttonNewCategory.Click += buttonNewCategory_Click;
            // 
            // buttonRemoveCategory
            // 
            buttonRemoveCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonRemoveCategory.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemoveCategory.Location = new System.Drawing.Point(123, 394);
            buttonRemoveCategory.MaximumSize = new System.Drawing.Size(110, 23);
            buttonRemoveCategory.MinimumSize = new System.Drawing.Size(110, 23);
            buttonRemoveCategory.Name = "buttonRemoveCategory";
            buttonRemoveCategory.Size = new System.Drawing.Size(110, 23);
            buttonRemoveCategory.TabIndex = 6;
            buttonRemoveCategory.Text = "Remove Category";
            buttonRemoveCategory.UseVisualStyleBackColor = true;
            buttonRemoveCategory.Click += buttonRemoveCategory_Click;
            // 
            // buttonNewSnippet
            // 
            buttonNewSnippet.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonNewSnippet.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonNewSnippet.Location = new System.Drawing.Point(239, 394);
            buttonNewSnippet.MaximumSize = new System.Drawing.Size(110, 23);
            buttonNewSnippet.MinimumSize = new System.Drawing.Size(110, 23);
            buttonNewSnippet.Name = "buttonNewSnippet";
            buttonNewSnippet.Size = new System.Drawing.Size(110, 23);
            buttonNewSnippet.TabIndex = 7;
            buttonNewSnippet.Text = "New Snippet";
            buttonNewSnippet.UseVisualStyleBackColor = true;
            buttonNewSnippet.Click += buttonNewSnippet_Click;
            // 
            // buttonRemoveSnippet
            // 
            buttonRemoveSnippet.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonRemoveSnippet.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemoveSnippet.Location = new System.Drawing.Point(353, 394);
            buttonRemoveSnippet.MaximumSize = new System.Drawing.Size(110, 23);
            buttonRemoveSnippet.MinimumSize = new System.Drawing.Size(110, 23);
            buttonRemoveSnippet.Name = "buttonRemoveSnippet";
            buttonRemoveSnippet.Size = new System.Drawing.Size(110, 23);
            buttonRemoveSnippet.TabIndex = 8;
            buttonRemoveSnippet.Text = "Remove Snippet";
            buttonRemoveSnippet.UseVisualStyleBackColor = true;
            buttonRemoveSnippet.Click += buttonRemoveSnippet_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(923, 24);
            menuStrip.TabIndex = 12;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { optionsToolStripMenuItem, statisticsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            optionsToolStripMenuItem.Text = "Options";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // statisticsToolStripMenuItem
            // 
            statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            statisticsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            statisticsToolStripMenuItem.Text = "Statistics";
            statisticsToolStripMenuItem.Click += statisticsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // richTextBoxSnippetContent
            // 
            richTextBoxSnippetContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBoxSnippetContent.Location = new System.Drawing.Point(468, 52);
            richTextBoxSnippetContent.MinimumSize = new System.Drawing.Size(445, 334);
            richTextBoxSnippetContent.Name = "richTextBoxSnippetContent";
            richTextBoxSnippetContent.Size = new System.Drawing.Size(445, 334);
            richTextBoxSnippetContent.TabIndex = 13;
            richTextBoxSnippetContent.Text = "";
            richTextBoxSnippetContent.TextChanged += richTextBoxSnippetContent_TextChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(923, 446);
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
            MinimumSize = new System.Drawing.Size(939, 485);
            Name = "MainWindow";
            Text = "Form1";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
    }
}
