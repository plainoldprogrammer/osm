using System.Windows.Forms;
using ConsoleApp;
using WindowsFormsApp;

namespace Osm
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

			this.RefreshStatistics();
		}

		private void StatisticsWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;

			_mainWindow.Enabled = true;
		}

		public void RefreshStatistics()
		{
			this.labelValueNumberOfSnippets.Text = _databaseAccess.GetNumberOfSnippets().ToString();
		}
	}
}
