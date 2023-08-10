using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp;
using WindowsFormsApp;

namespace Osm
{
	public partial class StatisticsWindow : Form
	{
		private MainWindow _mainWindow;

		public StatisticsWindow(MainWindow mainWindow, DatabaseAccess databaseAccess)
		{
			InitializeComponent();

			_mainWindow = mainWindow;
			this.labelValueNumberOfSnippets.Text = databaseAccess.GetNumberOfSnippets().ToString();
		}

		private void StatisticsWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;

			_mainWindow.Enabled = true;
		}
	}
}
