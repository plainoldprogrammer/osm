/*
 * Name:    OSM
 * Author:  Plainoldprogrammer
 * Editor:  Visual Studio 2022 (Community Edition)
 */

using System.Windows.Forms;
using ConsoleApp;

namespace WindowsFormsApp
{
	public partial class StatisticsWindow : Form
	{
		private MainWindow _mainWindow;
		private DatabaseAccess _databaseAccess;

		public StatisticsWindow(MainWindow mainWindow, DatabaseAccess databaseAccess)
		{
			InitializeComponent();

			this._mainWindow = mainWindow;
			this._databaseAccess = databaseAccess;

			this.CenterToScreen();
            this.MaximizeBox = false;
        }

		public void ShowStatistics()
		{
			this.RefreshStatistics();
			this.Show();
		}

		private void StatisticsWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;

			this._mainWindow.Enabled = true;
		}

		private void RefreshStatistics()
		{
			this.labelValueNumberOfCategories.Text = this._databaseAccess.GetNumberOfCategories().ToString();
			this.labelValueNumberOfSnippets.Text = this._databaseAccess.GetNumberOfSnippets().ToString();
		}
	}
}
