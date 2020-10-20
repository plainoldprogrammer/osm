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
            this.Text = "Osm";
            DatabaseAccess databaseAccess = new DatabaseAccess();
        }
    }
}
