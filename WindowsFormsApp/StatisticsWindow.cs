﻿/*
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

			_mainWindow = mainWindow;
			_databaseAccess = databaseAccess;

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

			_mainWindow.Enabled = true;
		}

		public void RefreshStatistics()
		{
			this.labelValueNumberOfCategories.Text = _databaseAccess.GetNumberOfCategories().ToString();
			this.labelValueNumberOfSnippets.Text = _databaseAccess.GetNumberOfSnippets().ToString();
		}
	}
}
