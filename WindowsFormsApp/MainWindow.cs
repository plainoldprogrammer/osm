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

            ToolStripMenuItem menuItemFile = new ToolStripMenuItem("File");
            ToolStripItem itemExit = new ToolStripButton("Exit");
            menuItemFile.DropDownItems.Add(itemExit);
            this.menuStrip.Items.Add(menuItemFile);

            this.menuStrip.Items.Add("Edit");
            this.menuStrip.Items.Add("Tools");
            this.menuStrip.Items.Add("Help");

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
