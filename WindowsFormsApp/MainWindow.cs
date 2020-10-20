using System;
using System.Windows.Forms;
using ConsoleApp;

namespace WindowsFormsApp
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        private DatabaseAccess databaseAccess;

        public MainWindow()
        {
            InitializeComponent();
            this.Text = "Osm v0.1";
            databaseAccess = new DatabaseAccess();
        }
    }
}
