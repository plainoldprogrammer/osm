namespace WindowsFormsApp
{
	partial class StatisticsWindow
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
			labelDescriptionNumberOfSnippets = new System.Windows.Forms.Label();
			labelValueNumberOfSnippets = new System.Windows.Forms.Label();
			labelDescriptionNumberOfCategories = new System.Windows.Forms.Label();
			labelValueNumberOfCategories = new System.Windows.Forms.Label();
			SuspendLayout();
			// 
			// labelDescriptionNumberOfSnippets
			// 
			labelDescriptionNumberOfSnippets.AutoSize = true;
			labelDescriptionNumberOfSnippets.Location = new System.Drawing.Point(12, 48);
			labelDescriptionNumberOfSnippets.Name = "labelDescriptionNumberOfSnippets";
			labelDescriptionNumberOfSnippets.Size = new System.Drawing.Size(143, 20);
			labelDescriptionNumberOfSnippets.TabIndex = 0;
			labelDescriptionNumberOfSnippets.Text = "Number of snippets:";
			// 
			// labelValueNumberOfSnippets
			// 
			labelValueNumberOfSnippets.AutoSize = true;
			labelValueNumberOfSnippets.Location = new System.Drawing.Point(175, 48);
			labelValueNumberOfSnippets.Name = "labelValueNumberOfSnippets";
			labelValueNumberOfSnippets.Size = new System.Drawing.Size(50, 20);
			labelValueNumberOfSnippets.TabIndex = 1;
			labelValueNumberOfSnippets.Text = "label2";
			// 
			// labelDescriptionNumberOfCategories
			// 
			labelDescriptionNumberOfCategories.AutoSize = true;
			labelDescriptionNumberOfCategories.Location = new System.Drawing.Point(12, 14);
			labelDescriptionNumberOfCategories.Name = "labelDescriptionNumberOfCategories";
			labelDescriptionNumberOfCategories.Size = new System.Drawing.Size(157, 20);
			labelDescriptionNumberOfCategories.TabIndex = 2;
			labelDescriptionNumberOfCategories.Text = "Number of categories:";
			// 
			// labelValueNumberOfCategories
			// 
			labelValueNumberOfCategories.AutoSize = true;
			labelValueNumberOfCategories.Location = new System.Drawing.Point(175, 14);
			labelValueNumberOfCategories.Name = "labelValueNumberOfCategories";
			labelValueNumberOfCategories.Size = new System.Drawing.Size(50, 20);
			labelValueNumberOfCategories.TabIndex = 3;
			labelValueNumberOfCategories.Text = "label1";
			// 
			// StatisticsWindow
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(281, 110);
			Controls.Add(labelValueNumberOfCategories);
			Controls.Add(labelDescriptionNumberOfCategories);
			Controls.Add(labelValueNumberOfSnippets);
			Controls.Add(labelDescriptionNumberOfSnippets);
			Name = "StatisticsWindow";
			Text = "Statistics";
			FormClosing += StatisticsWindow_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label labelDescriptionNumberOfSnippets;
		private System.Windows.Forms.Label labelValueNumberOfSnippets;
		private System.Windows.Forms.Label labelDescriptionNumberOfCategories;
		private System.Windows.Forms.Label labelValueNumberOfCategories;
	}
}