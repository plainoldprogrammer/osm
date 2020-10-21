﻿using System;
using System.Windows.Forms;
using ConsoleApp;
using System.Collections.Generic;
using System.ComponentModel;

namespace WindowsFormsApp
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        private DatabaseAccess databaseAccess;
        ToolStripMenuItem menuItemFile;
        ToolStripMenuItem menuItemEdit;
        ToolStripMenuItem menuItemTools;
        ToolStripMenuItem menuItemAbout;

        public MainWindow()
        {
            InitializeComponent();
            InitializeDatabaseAcess();
            InitializeGui();
        }

        private void InitializeDatabaseAcess()
        {
            databaseAccess = new DatabaseAccess();
        }

        private void InitializeGui()
        {
            this.Text = "Osm v0.1";
            InitializeMenuStrip();
            InitializeListBoxCategories();
        }

        private void InitializeMenuStrip()
        {
            menuItemFile = new ToolStripMenuItem("File");
            ToolStripButton itemExit = new ToolStripButton("Exit");
            menuItemFile.DropDownItems.Add(itemExit);
            this.menuStrip.Items.Add(menuItemFile);

            menuItemEdit = new ToolStripMenuItem("File");
            ToolStripButton itemCut = new ToolStripButton("Cut");
            ToolStripButton itemCopy = new ToolStripButton("Copy");
            ToolStripButton itemPaste = new ToolStripButton("Paste");
            menuItemEdit.DropDownItems.Add(itemCut);
            menuItemEdit.DropDownItems.Add(itemCopy);
            menuItemEdit.DropDownItems.Add(itemPaste);
            this.menuStrip.Items.Add(menuItemEdit);

            menuItemTools = new ToolStripMenuItem("Tools");
            ToolStripButton itemTools = new ToolStripButton("Tools");
            menuItemTools.DropDownItems.Add(itemTools);
            this.menuStrip.Items.Add(menuItemTools);

            menuItemAbout = new ToolStripMenuItem("Help");
            ToolStripButton itemAbout = new ToolStripButton("About");
            menuItemAbout.DropDownItems.Add(itemAbout);
            this.menuStrip.Items.Add(menuItemAbout);
        }

        private void InitializeListBoxCategories()
        {
            List<String> categories = databaseAccess.GetCategories();

            foreach (String category in categories)
            {
                this.listBoxCategories.Items.Add(category);
            }
        }

        private void listBoxCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            String category = listBoxCategories.SelectedItem.ToString();
            List<String> titles = databaseAccess.GetSnippetTitlesFromACategory(category);
            listBoxSnippets.Items.Clear();

            foreach (String title in titles)
            {
                listBoxSnippets.Items.Add(title);
            }
        }
    }
}
