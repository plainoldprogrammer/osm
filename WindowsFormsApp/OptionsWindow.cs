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
        private DatabaseAccess _databaseAccess;

        public OptionsWindow(MainWindow mainWindow, DatabaseAccess databaseAccess)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _databaseAccess = databaseAccess;
            this.textBoxDbFile.Text = _databaseAccess.GetDatabasePath();
            GetAllSystemInstalledFonts();
            this.AcceptButton = this.buttonOk;
            this.CancelButton = this.buttonCancel;

            this.comboBoxTheme.SelectedIndex = 0;

            float fontSize = _mainWindow.GetRichTextBoxSnippetContentFontSize();
            int indexFontSize = this.comboBoxFontSize.Items.IndexOf(((int)fontSize).ToString());
            this.comboBoxFontSize.SelectedIndex = indexFontSize;

            Font font = _mainWindow.GetRichTextBoxSnippetContentFont();
            int indexFont = this.comboBoxFont.Items.IndexOf(font.FontFamily.Name);
            this.comboBoxFont.SelectedIndex = indexFont;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _mainWindow.Enabled = true;

            if (this.comboBoxTheme.SelectedItem == "Light")
            {
                _mainWindow.SetListBoxCategoriesColor("light");
                _mainWindow.SetListBoxSnippetsColor("light");
            }
            else if (this.comboBoxTheme.SelectedItem == "Dark")
            {
                _mainWindow.SetListBoxCategoriesColor("dark");
                _mainWindow.SetListBoxSnippetsColor("dark");
                _mainWindow.SetTextBoxSnippetTitleColor("dark");
                _mainWindow.SetRichTextBoxSnippetContentColor("dark");
            }

            if (this.comboBoxFont.SelectedItem is not null)
            {
                String selectedFont = this.comboBoxFont.SelectedItem.ToString();
                _mainWindow.SetFont(selectedFont);
            }

            if (this.comboBoxFontSize.SelectedItem is not null)
            {
                int fontSize = 9;
                Int32.TryParse(this.comboBoxFontSize.SelectedItem.ToString(), out fontSize);
                _mainWindow.SetFontSize(fontSize);
            }

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

        private void buttonSelectDbFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string filePath = this.textBoxDbFile.Text; ;
            string directory = filePath.Substring(0, filePath.LastIndexOf("\\"));
            openFileDialog.InitialDirectory = directory;

            openFileDialog.ShowDialog();
        }

        private void checkBoxWordWrap_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
