/*
 * Name:    OSM
 * Author:  Plainoldprogrammer
 * Editor:  Visual Studio 2022 (Community Edition)
 */

using ConsoleApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace Osm
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
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
			_mainWindow.Enabled = true;
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
			this.Hide();
		}
	}
}
