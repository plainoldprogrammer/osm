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
            ToolStripButton itemExit = new ToolStripButton("Exit");
            menuItemFile.DropDownItems.Add(itemExit);
            this.menuStrip.Items.Add(menuItemFile);

            ToolStripMenuItem menuItemEdit = new ToolStripMenuItem("File");
            ToolStripButton itemCut = new ToolStripButton("Cut");
            ToolStripButton itemCopy = new ToolStripButton("Copy");
            ToolStripButton itemPaste = new ToolStripButton("Paste");
            menuItemEdit.DropDownItems.Add(itemCut);
            menuItemEdit.DropDownItems.Add(itemCopy);
            menuItemEdit.DropDownItems.Add(itemPaste);
            this.menuStrip.Items.Add(menuItemEdit);

            ToolStripMenuItem menuItemTools = new ToolStripMenuItem("Tools");
            ToolStripButton itemTools = new ToolStripButton("Tools");
            menuItemTools.DropDownItems.Add(itemTools);
            this.menuStrip.Items.Add(menuItemTools);

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
