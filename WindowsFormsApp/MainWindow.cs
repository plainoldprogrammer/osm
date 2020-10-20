using System;
using System.Windows.Forms;
using ConsoleApp;

namespace WindowsFormsApp
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Text = "Osm v0.1";
            DatabaseAccess databaseAccess = new DatabaseAccess();
        }
    }
}
