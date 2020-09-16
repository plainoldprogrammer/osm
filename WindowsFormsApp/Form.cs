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
            DatabaseAccess databaseAccess = new DatabaseAccess();
            textBox1.Text = databaseAccess.GetSnippetsTitles();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
