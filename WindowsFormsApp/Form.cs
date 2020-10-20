using System;
using System.Windows.Forms;
using ConsoleApp;

namespace WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.Text = "Other Snippet Manager";
            DatabaseAccess databaseAccess = new DatabaseAccess();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
