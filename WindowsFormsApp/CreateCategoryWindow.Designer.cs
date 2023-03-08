namespace Osm
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
			label1 = new System.Windows.Forms.Label();
			textBox1 = new System.Windows.Forms.TextBox();
			button1 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(25, 27);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(116, 20);
			label1.TabIndex = 0;
			label1.Text = "Category Name:";
			// 
			// textBox1
			// 
			textBox1.Location = new System.Drawing.Point(147, 24);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(181, 27);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(82, 100);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(94, 29);
			button1.TabIndex = 2;
			button1.Text = "Ok";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new System.Drawing.Point(194, 100);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(94, 29);
			button2.TabIndex = 3;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			// 
			// CreateCategoryWindow
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(363, 161);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "CreateCategoryWindow";
			Text = "New Category";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}