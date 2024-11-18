/*
 * Name:    OSM
 * Author:  Plainoldprogrammer
 * Editor:  Visual Studio 2022 (Community Edition)
 */

using ConsoleApp;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class CreateCategoryWindow : Form
    {
        private MainWindow _mainWindow;
        private DatabaseAccess _databaseAccess;

        public CreateCategoryWindow(MainWindow mainWindow, DatabaseAccess databaseAccess)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
            _databaseAccess = databaseAccess;

            textBoxCategoryName.Select();
            this.AcceptButton = this.buttonOk;
            this.CancelButton = this.buttonCancel;
            this.CenterToScreen();
            this.MaximizeBox = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string category = textBoxCategoryName.Text;
            _mainWindow.Enabled = true;
            _databaseAccess.CreateCategory(category);
            _mainWindow.RefreshCategoriesListBox();
            this.textBoxCategoryName.Text = "";
            textBoxCategoryName.Select();
            _mainWindow.EnableRemoveCategoryButton();
            _mainWindow.EnableButtonNewSnippet();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainWindow.Enabled = true;
        }
    }
}
