using System;
using System.Windows.Forms;
using ConsoleApp;
using System.Collections.Generic;
using System.ComponentModel;

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
            InitializeListBoxCategories();
        }

        private void InitializeListBoxCategories()
        {
            List<String> categories = databaseAccess.GetCategories();

            foreach (String category in categories)
            {
                this.listBoxCategories.Items.Add(category);
            }
        }
    }
}
