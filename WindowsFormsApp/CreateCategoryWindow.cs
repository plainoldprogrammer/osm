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
		public CreateCategoryWindow(MainWindow mainWindow)
		{
			InitializeComponent();
			_mainWindow = mainWindow;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
			_mainWindow.Enabled = true;
		}
	}
}
