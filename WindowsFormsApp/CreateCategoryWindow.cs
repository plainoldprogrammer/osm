﻿/*
 * Name:    OSM
 * Author:  Plainoldprogrammer
 * Editor:  Visual Studio 2022 (Community Edition)
 */

using System;
using System.Windows.Forms;
using ConsoleApp;

namespace WindowsFormsApp
{
    public partial class CreateCategoryWindow : Form
    {
        private MainWindow _mainWindow;
        private DatabaseAccess _databaseAccess;

        public CreateCategoryWindow(MainWindow mainWindow, DatabaseAccess databaseAccess)
        {
            InitializeComponent();

            this._mainWindow = mainWindow;
            this._databaseAccess = databaseAccess;

            this.textBoxCategoryName.Select();
            this.AcceptButton = this.buttonOk;
            this.CancelButton = this.buttonCancel;
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            String category = textBoxCategoryName.Text;
            this._mainWindow.Enabled = true;

            if (category != String.Empty)
            {
                
                this._databaseAccess.CreateCategory(category);
                this._mainWindow.RefreshCategoriesListBox();
                this.textBoxCategoryName.Text = String.Empty;
                this.textBoxCategoryName.Select();
                this._mainWindow.EnableRemoveCategoryButton();
                this._mainWindow.EnableButtonNewSnippet();
            }

            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._mainWindow.Enabled = true;
        }
    }
}
