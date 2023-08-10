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

namespace Osm
{
	public partial class StatisticsWindow : Form
	{
		public StatisticsWindow(DatabaseAccess databaseAccess)
		{
			InitializeComponent();

			this.labelValueNumberOfSnippets.Text = databaseAccess.GetNumberOfSnippets().ToString();
		}
	}
}
