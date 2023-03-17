using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace Osm
{
    public partial class OptionsWindow : Form
    {
        private MainWindow _mainWindow;

        public OptionsWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            GetAllSystemInstalledFonts();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _mainWindow.Enabled = true;

            int fontSize = 9;
            if (comboBoxFontSize.SelectedItem is not null)
            {
                Int32.TryParse(comboBoxFontSize.SelectedItem.ToString(), out fontSize);
            }
            _mainWindow.SetFontSize(fontSize);

            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _mainWindow.Enabled = true;
            this.Hide();
        }

        private void GetAllSystemInstalledFonts()
        {
            using (InstalledFontCollection fontCollection = new InstalledFontCollection())
            {
                foreach (FontFamily fontFamily in fontCollection.Families)
                {
                    this.comboBoxFont.Items.Add(fontFamily.Name);
                }
            }
        }
    }
}
