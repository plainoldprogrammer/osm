﻿/*
 * Name:    OSM
 * Author:  Plainoldprogrammer
 * Editor:  Visual Studio 2022 (Community Edition)
 */

using ConsoleApp;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WindowsFormsApp
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

            var applicationThemeOnConfig = Properties.Settings.Default["ApplicationTheme"];

            if (applicationThemeOnConfig.ToString().ToLower().Equals("") || applicationThemeOnConfig.ToString().ToLower().Equals("light"))
            {
                this.comboBoxTheme.SelectedIndex = 0;
            }
            else if (applicationThemeOnConfig.ToString().ToLower().Equals("dark"))
            {
                this.comboBoxTheme.SelectedIndex = 1;
            }

            Font font = _mainWindow.GetRichTextBoxSnippetContentFont();
            int indexFont = this.comboBoxFont.Items.IndexOf(font.FontFamily.Name);
            this.comboBoxFont.SelectedIndex = indexFont;

            float fontSize = _mainWindow.GetRichTextBoxSnippetContentFontSize();
            int indexFontSize = this.comboBoxFontSize.Items.IndexOf(((int)fontSize).ToString());
            this.comboBoxFontSize.SelectedIndex = indexFontSize;

            this.buttonOk.Select();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.CenterToScreen();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _mainWindow.Enabled = true;

            if (this.comboBoxTheme.SelectedItem == "Light")
            {
                _mainWindow.SetLightTheme();

                Properties.Settings.Default["ApplicationTheme"] = "Light";
                Properties.Settings.Default.Save();
            }
            else if (this.comboBoxTheme.SelectedItem == "Dark")
            {
                _mainWindow.SetDarkTheme();

                Properties.Settings.Default["ApplicationTheme"] = "Dark";
                Properties.Settings.Default.Save();
            }

            if (this.comboBoxFont.SelectedItem is not null)
            {
                String selectedFont = this.comboBoxFont.SelectedItem.ToString();
                _mainWindow.SetFont(selectedFont, Int32.Parse(this.comboBoxFontSize.SelectedItem.ToString()));

                Properties.Settings.Default["ApplicationFontFamily"] = selectedFont;
            }

            if (this.comboBoxFontSize.SelectedItem is not null)
            {
                int fontSize = 9;
                Int32.TryParse(this.comboBoxFontSize.SelectedItem.ToString(), out fontSize);
                _mainWindow.SetFontSize(fontSize);

                Properties.Settings.Default["ApplicationFontSize"] = fontSize.ToString();
                Properties.Settings.Default.Save();
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

        private void OptionsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;

            _mainWindow.Enabled = true;
        }

        public void SetFontSize(int fontSize)
        {
            int indexFontSize = this.comboBoxFontSize.Items.IndexOf(((int)fontSize).ToString());
            this.comboBoxFontSize.SelectedIndex = indexFontSize;
            this._mainWindow.SetFontSize(fontSize);
        }

        public void SetFontFamily(string fontFamily)
        {
            int indexFont = this.comboBoxFont.Items.IndexOf(fontFamily);
            this.comboBoxFont.SelectedIndex = indexFont;

            int fontSize = Int32.Parse(this.comboBoxFontSize.SelectedItem.ToString());
            this._mainWindow.SetFont(fontFamily, fontSize);
        }
    }
}
