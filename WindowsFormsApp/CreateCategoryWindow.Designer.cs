namespace WindowsFormsApp
{
	partial class CreateCategoryWindow
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
			labelNewCategory = new System.Windows.Forms.Label();
			textBoxCategoryName = new System.Windows.Forms.TextBox();
			buttonOk = new System.Windows.Forms.Button();
			buttonCancel = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// labelNewCategory
			// 
			labelNewCategory.AutoSize = true;
			labelNewCategory.Location = new System.Drawing.Point(25, 27);
			labelNewCategory.Name = "labelNewCategory";
			labelNewCategory.Size = new System.Drawing.Size(116, 20);
			labelNewCategory.TabIndex = 0;
			labelNewCategory.Text = "Category Name:";
			// 
			// textBoxCategoryName
			// 
			textBoxCategoryName.Location = new System.Drawing.Point(147, 24);
			textBoxCategoryName.Name = "textBoxCategoryName";
			textBoxCategoryName.Size = new System.Drawing.Size(181, 27);
			textBoxCategoryName.TabIndex = 1;
			// 
			// buttonOk
			// 
			buttonOk.Location = new System.Drawing.Point(82, 100);
			buttonOk.Name = "buttonOk";
			buttonOk.Size = new System.Drawing.Size(94, 29);
			buttonOk.TabIndex = 2;
			buttonOk.Text = "Ok";
			buttonOk.UseVisualStyleBackColor = true;
			buttonOk.Click += buttonOk_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Location = new System.Drawing.Point(194, 100);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new System.Drawing.Size(94, 29);
			buttonCancel.TabIndex = 3;
			buttonCancel.Text = "Cancel";
			buttonCancel.UseVisualStyleBackColor = true;
			buttonCancel.Click += buttonCancel_Click;
			// 
			// CreateCategoryWindow
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(363, 161);
			Controls.Add(buttonCancel);
			Controls.Add(buttonOk);
			Controls.Add(textBoxCategoryName);
			Controls.Add(labelNewCategory);
			Name = "CreateCategoryWindow";
			Text = "New Category";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label labelNewCategory;
		private System.Windows.Forms.TextBox textBoxCategoryName;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
	}
}