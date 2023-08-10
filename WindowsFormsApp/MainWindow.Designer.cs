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
			label1.Location = new System.Drawing.Point(12, 41);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(80, 20);
			label1.TabIndex = 1;
			label1.Text = "Categories";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			label2.Location = new System.Drawing.Point(273, 41);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(66, 20);
			label2.TabIndex = 2;
			label2.Text = "Snippets";
			// 
			// textBoxSnippetTitle
			// 
			textBoxSnippetTitle.Location = new System.Drawing.Point(538, 34);
			textBoxSnippetTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			textBoxSnippetTitle.Name = "textBoxSnippetTitle";
			textBoxSnippetTitle.Size = new System.Drawing.Size(505, 27);
			textBoxSnippetTitle.TabIndex = 9;
			textBoxSnippetTitle.TextChanged += textBoxSnippetTitle_TextChanged;
			// 
			// listBoxCategories
			// 
			listBoxCategories.FormattingEnabled = true;
			listBoxCategories.ItemHeight = 20;
			listBoxCategories.Location = new System.Drawing.Point(11, 70);
			listBoxCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			listBoxCategories.Name = "listBoxCategories";
			listBoxCategories.Size = new System.Drawing.Size(256, 444);
			listBoxCategories.TabIndex = 3;
			listBoxCategories.SelectedValueChanged += listBoxCategories_SelectedValueChanged;
			// 
			// listBoxSnippets
			// 
			listBoxSnippets.FormattingEnabled = true;
			listBoxSnippets.ItemHeight = 20;
			listBoxSnippets.Location = new System.Drawing.Point(273, 70);
			listBoxSnippets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			listBoxSnippets.Name = "listBoxSnippets";
			listBoxSnippets.Size = new System.Drawing.Size(256, 444);
			listBoxSnippets.TabIndex = 4;
			listBoxSnippets.SelectedValueChanged += listBoxSnippets_SelectedValueChanged;
			// 
			// buttonNewCategory
			// 
			buttonNewCategory.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			buttonNewCategory.Location = new System.Drawing.Point(11, 525);
			buttonNewCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			buttonNewCategory.Name = "buttonNewCategory";
			buttonNewCategory.Size = new System.Drawing.Size(126, 31);
			buttonNewCategory.TabIndex = 5;
			buttonNewCategory.Text = "New Category";
			buttonNewCategory.UseVisualStyleBackColor = true;
			buttonNewCategory.Click += buttonNewCategory_Click;
			// 
			// buttonRemoveCategory
			// 
			buttonRemoveCategory.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			buttonRemoveCategory.Location = new System.Drawing.Point(141, 525);
			buttonRemoveCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			buttonRemoveCategory.Name = "buttonRemoveCategory";
			buttonRemoveCategory.Size = new System.Drawing.Size(126, 31);
			buttonRemoveCategory.TabIndex = 6;
			buttonRemoveCategory.Text = "Remove Category";
			buttonRemoveCategory.UseVisualStyleBackColor = true;
			buttonRemoveCategory.Click += buttonRemoveCategory_Click;
			// 
			// buttonNewSnippet
			// 
			buttonNewSnippet.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			buttonNewSnippet.Location = new System.Drawing.Point(273, 525);
			buttonNewSnippet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			buttonNewSnippet.Name = "buttonNewSnippet";
			buttonNewSnippet.Size = new System.Drawing.Size(126, 31);
			buttonNewSnippet.TabIndex = 7;
			buttonNewSnippet.Text = "New Snippet";
			buttonNewSnippet.UseVisualStyleBackColor = true;
			buttonNewSnippet.Click += buttonNewSnippet_Click;
			// 
			// buttonRemoveSnippet
			// 
			buttonRemoveSnippet.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			buttonRemoveSnippet.Location = new System.Drawing.Point(403, 525);
			buttonRemoveSnippet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			buttonRemoveSnippet.Name = "buttonRemoveSnippet";
			buttonRemoveSnippet.Size = new System.Drawing.Size(126, 31);
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
			menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
			menuStrip.Size = new System.Drawing.Size(1055, 30);
			menuStrip.TabIndex = 12;
			menuStrip.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
			exitToolStripMenuItem.Text = "Exit";
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, selectAllToolStripMenuItem });
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
			editToolStripMenuItem.Text = "Edit";
			// 
			// cutToolStripMenuItem
			// 
			cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			cutToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
			cutToolStripMenuItem.Text = "Cut";
			cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
			// 
			// copyToolStripMenuItem
			// 
			copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			copyToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
			copyToolStripMenuItem.Text = "Copy";
			copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
			// 
			// pasteToolStripMenuItem
			// 
			pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			pasteToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
			pasteToolStripMenuItem.Text = "Paste";
			pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
			// 
			// selectAllToolStripMenuItem
			// 
			selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			selectAllToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
			selectAllToolStripMenuItem.Text = "Select All";
			selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
			// 
			// toolsToolStripMenuItem
			// 
			toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { optionsToolStripMenuItem, statisticsToolStripMenuItem });
			toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			toolsToolStripMenuItem.Text = "Tools";
			// 
			// optionsToolStripMenuItem
			// 
			optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			optionsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
			optionsToolStripMenuItem.Text = "Options";
			optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
			// 
			// statisticsToolStripMenuItem
			// 
			statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
			statisticsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
			statisticsToolStripMenuItem.Text = "Statistics";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			aboutToolStripMenuItem.Text = "About";
			aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
			// 
			// richTextBoxSnippetContent
			// 
			richTextBoxSnippetContent.Location = new System.Drawing.Point(535, 70);
			richTextBoxSnippetContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			richTextBoxSnippetContent.Name = "richTextBoxSnippetContent";
			richTextBoxSnippetContent.Size = new System.Drawing.Size(508, 444);
			richTextBoxSnippetContent.TabIndex = 13;
			richTextBoxSnippetContent.Text = "";
			richTextBoxSnippetContent.TextChanged += richTextBoxSnippetContent_TextChanged;
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1055, 594);
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
			Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
