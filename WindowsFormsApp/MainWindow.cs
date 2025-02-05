﻿/*
 * Name:    OSM
 * Author:  Plainoldprogrammer
 * Editor:  Visual Studio 2022 (Community Edition)
 */

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using ConsoleApp;
using ConsoleApp.Models;

namespace WindowsFormsApp
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        private const String _RELEASE_TYPE = "Alpha";
        private const String _VERSION_NUMBER = "0.5";
        private const String _VERSION = $"{_VERSION_NUMBER} ({_RELEASE_TYPE})";

        private const String _YEAR = "2023";
        private const String _MONTH = "August";
        private const String _DAY = "11";
        private const String _RELEASE_DATE = $"{_YEAR} {_MONTH} {_DAY}";

        private DatabaseAccess _databaseAccess;

        private CreateCategoryWindow _createCategoryWindow;
        private OptionsWindow _optionsWindow;
        private StatisticsWindow _statisticsWindow;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public MainWindow()
        {
            // this.EnableDebuggingConsole();

            InitializeComponent();

            this.InitializeDatabaseAcess();

            this._createCategoryWindow = new CreateCategoryWindow(this, this._databaseAccess);
            this._optionsWindow = new OptionsWindow(this, this._databaseAccess);
            this._statisticsWindow = new StatisticsWindow(this, this._databaseAccess);

            this.InitializeGui();

            this.CenterToScreen();
        }

        private void EnableDebuggingConsole()
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                AllocConsole();
            }
        }

        private void InitializeDatabaseAcess()
        {
            this._databaseAccess = new DatabaseAccess();
        }

        private void InitializeGui()
        {
            this.Text = $"Osm v{_VERSION}";
            this.richTextBoxSnippetContent.AcceptsTab = true;
            SetTabWidth(this.richTextBoxSnippetContent, 1);

            var applicationThemeOnConfig = WindowsFormsApp.Properties.Settings.Default["ApplicationTheme"];

            if (applicationThemeOnConfig.ToString().ToLower().Equals("") || applicationThemeOnConfig.ToString().ToLower().Equals("light"))
            {
                this.ConfigureListBoxCategoriesLightTheme();
                this.ConfigureListBoxSnippetsLightTheme();
                this.SetLightTheme();
            }
            else if (applicationThemeOnConfig.ToString().ToLower().Equals("dark"))
            {
                this.ConfigureListBoxCategoriesDarkTheme();
                this.ConfigureListBoxSnippetsDarkTheme();
                this.SetDarkTheme();
            }

            var applicationFontSizeOnConfig = WindowsFormsApp.Properties.Settings.Default["ApplicationFontSize"].ToString();

            if (applicationFontSizeOnConfig == "")
            {
                applicationFontSizeOnConfig = "9";
            }

            this._optionsWindow.SetFontSize(Int32.Parse(applicationFontSizeOnConfig));

            var applicationFontFamilyOnConfig = WindowsFormsApp.Properties.Settings.Default["ApplicationFontFamily"].ToString();
            this._optionsWindow.SetFontFamily(applicationFontFamilyOnConfig);

            InitializeListBoxCategories();
            InitializeListBoxSnippets();

            if (this.listBoxCategories.Items.Count == 0)
            {
                this.buttonRemoveCategory.Enabled = false;
                this.buttonNewSnippet.Enabled = false;
                this.buttonCopySnippet.Enabled = false;
                this.textBoxSnippetTitle.Enabled = false;
                this.richTextBoxSnippetContent.Enabled = false;
            }

            this.exitToolStripMenuItem.Click += ItemExit_Clicked;
            this.richTextBoxSnippetContent.WordWrap = false;
            this.DisableEditButtons();
        }

        private void ConfigureListBoxCategoriesLightTheme()
        {
            this.listBoxCategories.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBoxCategories.DrawItem -= new DrawItemEventHandler(listBoxCategories_DrawItemDarkTheme);
            this.listBoxCategories.DrawItem += new DrawItemEventHandler(listBoxCategories_DrawItem);
        }

        public void ConfigureListBoxCategoriesDarkTheme()
        {
            this.listBoxCategories.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBoxCategories.DrawItem -= new DrawItemEventHandler(listBoxCategories_DrawItem);
            this.listBoxCategories.DrawItem += new DrawItemEventHandler(listBoxCategories_DrawItemDarkTheme);
        }

        private void ConfigureListBoxSnippetsLightTheme()
        {
            this.listBoxSnippets.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBoxSnippets.DrawItem -= new DrawItemEventHandler(listBoxSnippets_DrawItemDarkTheme);
            this.listBoxSnippets.DrawItem += new DrawItemEventHandler(listBoxSnippets_DrawItem);
        }

        private void ConfigureListBoxSnippetsDarkTheme()
        {
            this.listBoxSnippets.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBoxSnippets.DrawItem -= new DrawItemEventHandler(listBoxCategories_DrawItem);
            this.listBoxSnippets.DrawItem += new DrawItemEventHandler(listBoxSnippets_DrawItemDarkTheme);
        }

        private void InitializeListBoxCategories()
        {
            this.listBoxCategories.DisplayMember = "Category1";
            this.listBoxCategories.ValueMember = "Id";
            this.RefreshCategoriesListBox();
        }

        private void InitializeListBoxSnippets()
        {
            this.listBoxSnippets.DisplayMember = "Title";
            this.listBoxSnippets.ValueMember = "Id";
        }

        public void RefreshCategoriesListBox()
        {
            if (this.listBoxCategories.Items.Count > 0)
            {
                this.listBoxCategories.Items.Clear();
            }

            List<Category> categories = this._databaseAccess.GetCategories();

            foreach (Category category in categories)
            {
                this.listBoxCategories.Items.Add(category);
            }

            this.listBoxCategories.SelectedIndex = this.listBoxCategories.Items.Count - 1;
            this.listBoxSnippets.HorizontalScrollbar = true;
            this.richTextBoxSnippetContent.Select(0, 0);
        }

        private void listBoxCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedIndex >= 0)
            {
                Category selectedCategory = listBoxCategories.SelectedItem as Category;
                this.listBoxSnippets.Items.Clear();
                List<Snippet> snippets = this._databaseAccess.GetAllSnippetsFromCategory(selectedCategory);

                foreach (Snippet snippet in snippets)
                {
                    this.listBoxSnippets.Items.Add(snippet);
                }

                if (snippets.Count > 0)
                {
                    this.listBoxSnippets.SelectedIndex = snippets.Count - 1;
                }
                else
                {
                    this.textBoxSnippetTitle.Text = "";
                    this.richTextBoxSnippetContent.Text = "";
                }
            }

            if (listBoxCategories.Items.Count == 0 || listBoxSnippets.Items.Count == 0)
            {
                this.buttonRemoveSnippet.Enabled = false;
                this.textBoxSnippetTitle.Enabled = false;
                this.richTextBoxSnippetContent.Enabled = false;
            }
            else
            {
                this.buttonRemoveSnippet.Enabled = true;
                this.textBoxSnippetTitle.Enabled = true;
                this.richTextBoxSnippetContent.Enabled = true;
            }
        }

        private void listBoxSnippets_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxSnippets.Items.Count > 0)
            {
                Snippet selectedSnippet = this.listBoxSnippets.SelectedItem as Snippet;

                if (selectedSnippet is not null)
                {
                    this.textBoxSnippetTitle.Text = selectedSnippet.Title;
                    this.richTextBoxSnippetContent.Text = selectedSnippet.Snippet1;
                    this.EnableEditButtons();
                }
            }
        }

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr h, int msg, int wParam, int[] lParam);

        public static void SetTabWidth(RichTextBox textbox, int tabWidth)
        {
            const int _EM_SETTABSTOPS = 0x00CB;
            Graphics graphics = textbox.CreateGraphics();
            var characterWidth = (int)graphics.MeasureString("M", textbox.Font).Width;
            SendMessage(textbox.Handle, _EM_SETTABSTOPS, 1, new int[] { tabWidth * characterWidth });
        }

        private void ItemExit_Clicked(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message = $"Osm\nOther Snippet Manager\nVersion: {_VERSION}\nRelease Date: {_RELEASE_DATE}\nDeveloper: PlainOldProgrammer";
            MessageBox.Show(message, "About Osm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBoxCategories_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBoxCategories.Items.Count > 0)
            {
                e.DrawBackground();
                e.Graphics.DrawIcon(new Icon("icons/folder.ico", 16, 16), e.Bounds.X, e.Bounds.Y);

                Rectangle textRectangle = e.Bounds;
                textRectangle.X += 18;

                e.Graphics.DrawString((listBoxCategories.Items[e.Index] as Category).Category1, e.Font, Brushes.Black, textRectangle, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void listBoxCategories_DrawItemDarkTheme(object sender, DrawItemEventArgs e)
        {
            if (listBoxCategories.Items.Count > 0)
            {
                e.DrawBackground();
                e.Graphics.DrawIcon(new Icon("icons/folder.ico", 16, 16), e.Bounds.X, e.Bounds.Y);

                Rectangle textRectangle = e.Bounds;
                textRectangle.X += 18;

                e.Graphics.DrawString((listBoxCategories.Items[e.Index] as Category).Category1, e.Font, Brushes.White, textRectangle, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void listBoxSnippets_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBoxSnippets.Items.Count > 0)
            {
                e.DrawBackground();
                e.Graphics.DrawIcon(new Icon("icons/file.ico", 16, 16), e.Bounds.X, e.Bounds.Y);

                Rectangle textRectangle = e.Bounds;
                textRectangle.X += 18;

                e.Graphics.DrawString((listBoxSnippets.Items[e.Index] as Snippet).Title,
                    e.Font, Brushes.Black, textRectangle, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
        }

        private void listBoxSnippets_DrawItemDarkTheme(object sender, DrawItemEventArgs e)
        {
            if (listBoxSnippets.Items.Count > 0)
            {
                e.DrawBackground();
                e.Graphics.DrawIcon(new Icon("icons/file.ico", 16, 16), e.Bounds.X, e.Bounds.Y);

                Rectangle textRectangle = e.Bounds;
                textRectangle.X += 18;

                e.Graphics.DrawString((listBoxSnippets.Items[e.Index] as Snippet).Title,
                    e.Font, Brushes.White, textRectangle, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
        }

        private void buttonNewCategory_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this._createCategoryWindow.Show();
        }

        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {
            if (this.listBoxCategories.Items.Count > 0)
            {
                DialogResult userSelection = MessageBox.Show("Remove category and all related snippets?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (userSelection == DialogResult.OK)
                {
                    var index = this.listBoxCategories.SelectedIndex;
                    Category selectedCategory = listBoxCategories.SelectedItem as Category;
                    this.listBoxCategories.Items.RemoveAt(index);

                    if (index > 0)
                    {
                        index--;
                    }

                    if (this.listBoxCategories.Items.Count > 0)
                    {
                        this.listBoxCategories.SelectedIndex = index;
                    }
                    else
                    {
                        this.listBoxSnippets.Items.Clear();

                        this.buttonRemoveCategory.Enabled = false;
                        this.buttonNewSnippet.Enabled = false;
                        this.buttonRemoveSnippet.Enabled = false;
                        this.buttonCopySnippet.Enabled = false;

                        this.listBoxSnippets.Enabled = false;
                        this.textBoxSnippetTitle.Enabled = false;
                        this.richTextBoxSnippetContent.Enabled = false;

                        this.textBoxSnippetTitle.Text = "";
                        this.richTextBoxSnippetContent.Text = "";
                    }

                    this._databaseAccess.RemoveCategory(selectedCategory);
                }
            }
        }

        private void buttonNewSnippet_Click(object sender, EventArgs e)
        {
            this.richTextBoxSnippetContent.Text = "";
            String titleOfNewSnippet = "New Snippet";

            Category selectedCategory = this.listBoxCategories.SelectedItem as Category;
            Snippet snippet = new Snippet()
            {
                Title = titleOfNewSnippet,
                CategoryId = selectedCategory.Id,
                Datetime = BitConverter.GetBytes(DateTime.Now.Ticks)
            };

            this._databaseAccess.CreateSnippet(snippet);

            if (this.listBoxSnippets.Items.Count == 0)
            {
                this.listBoxSnippets.Enabled = true;
            }

            this.listBoxSnippets.Items.Add(snippet);

            this.listBoxSnippets.SelectedIndex = this.listBoxSnippets.Items.Count - 1;
            this.textBoxSnippetTitle.Text = titleOfNewSnippet;
            this.textBoxSnippetTitle.Focus();

            if (!this.textBoxSnippetTitle.Enabled && !this.richTextBoxSnippetContent.Enabled)
            {
                this.textBoxSnippetTitle.Enabled = true;
                this.richTextBoxSnippetContent.Enabled = true;
            }

            if (this.buttonRemoveSnippet.Enabled == false)
            {
                this.buttonRemoveSnippet.Enabled = true;
            }

            if (this.buttonCopySnippet.Enabled == false)
            {
                this.buttonCopySnippet.Enabled = true;
            }

            this.textBoxSnippetTitle.Focus();
        }

        private void buttonRemoveSnippet_Click(object sender, EventArgs e)
        {
            if (this.listBoxSnippets.Items.Count > 0)
            {
                Snippet selectedSnippet = this.listBoxSnippets.SelectedItem as Snippet;
                int index = this.listBoxSnippets.SelectedIndex;
                this._databaseAccess.RemoveSnippet(selectedSnippet);
                this.listBoxSnippets.Items.RemoveAt(index);
                index--;

                if (index == -1)
                {
                    index = 0;
                }

                if (this.listBoxSnippets.Items.Count > 0)
                {
                    this.listBoxSnippets.SelectedIndex = index;
                }

                if (this.listBoxSnippets.Items.Count == 0)
                {
                    this.listBoxSnippets.Enabled = false;
                    this.textBoxSnippetTitle.Enabled = false;
                    this.richTextBoxSnippetContent.Enabled = false;
                    this.buttonRemoveSnippet.Enabled = false;
                    this.buttonCopySnippet.Enabled = false;

                    this.textBoxSnippetTitle.Text = "";
                    this.richTextBoxSnippetContent.Text = "";
                }
            }
        }

        private void textBoxSnippetTitle_TextChanged(object sender, EventArgs e)
        {
            if (listBoxSnippets.Items.Count > 0)
            {
                String title = ((TextBox)sender).Text;
                Snippet selectedSnippet = this.listBoxSnippets.SelectedItem as Snippet;
                selectedSnippet.Title = title;
                _databaseAccess.UpdateSnippet(selectedSnippet);
            }
        }

        public void EnableRemoveCategoryButton()
        {
            this.buttonRemoveCategory.Enabled = true;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this._optionsWindow.Show();
        }

        public void SetFont(String fontFamily, int fontSize)
        {
            this.richTextBoxSnippetContent.Font = new Font(fontFamily, fontSize);
        }

        public void SetFontSize(int fontSize)
        {
            this.richTextBoxSnippetContent.Font = new Font(this.richTextBoxSnippetContent.Font.FontFamily, fontSize);
        }

        private void richTextBoxSnippetContent_TextChanged(object sender, EventArgs e)
        {
            String content = ((RichTextBox)sender).Text;
            Snippet selectedSnippet = this.listBoxSnippets.SelectedItem as Snippet;

            if (selectedSnippet is not null)
            {
                selectedSnippet.Snippet1 = content;
                this._databaseAccess.UpdateSnippet(selectedSnippet);
            }
        }

        public float GetRichTextBoxSnippetContentFontSize()
        {
            return this.richTextBoxSnippetContent.Font.Size;
        }

        public Font GetRichTextBoxSnippetContentFont()
        {
            return this.richTextBoxSnippetContent.Font;
        }

        public void SetLightTheme()
        {
            this.SetListBoxCategoriesColor("light");
            this.SetListBoxSnippetsColor("light");
            this.SetTextBoxSnippetTitleColor("light");
            this.SetRichTextBoxSnippetContentColor("light");
        }

        public void SetDarkTheme()
        {
            this.SetListBoxCategoriesColor("dark");
            this.SetListBoxSnippetsColor("dark");
            this.SetTextBoxSnippetTitleColor("dark");
            this.SetRichTextBoxSnippetContentColor("dark");
        }

        private void SetListBoxCategoriesColor(String theme)
        {
            if (theme.ToLower() == "light")
            {
                this.listBoxCategories.BackColor = Color.FromArgb(255, 255, 255);
                this.ConfigureListBoxCategoriesLightTheme();
            }
            else if (theme.ToLower() == "dark")
            {
                this.listBoxCategories.BackColor = Color.FromArgb(48, 48, 48);
                this.ConfigureListBoxCategoriesDarkTheme();
            }
        }

        private void SetListBoxSnippetsColor(String theme)
        {
            if (theme.ToLower() == "light")
            {
                this.listBoxSnippets.BackColor = Color.FromArgb(255, 255, 255);
                this.ConfigureListBoxSnippetsLightTheme();
            }
            else if (theme.ToLower() == "dark")
            {
                this.listBoxSnippets.BackColor = Color.FromArgb(48, 48, 48);
                this.ConfigureListBoxSnippetsDarkTheme();
            }
        }

        private void SetTextBoxSnippetTitleColor(String theme)
        {
            if (theme.ToLower() == "light")
            {
                this.textBoxSnippetTitle.BackColor = Color.FromArgb(255, 255, 255);
                this.textBoxSnippetTitle.ForeColor = Color.Black;
            }
            else if (theme.ToLower() == "dark")
            {
                this.textBoxSnippetTitle.BackColor = Color.FromArgb(48, 48, 48);
                this.textBoxSnippetTitle.ForeColor = Color.White;
            }
        }

        private void SetRichTextBoxSnippetContentColor(String theme)
        {
            if (theme.ToLower() == "light")
            {
                this.richTextBoxSnippetContent.BackColor = Color.FromArgb(255, 255, 255);
                this.richTextBoxSnippetContent.ForeColor = Color.Black;
            }
            else if (theme.ToLower() == "dark")
            {
                this.richTextBoxSnippetContent.BackColor = Color.FromArgb(48, 48, 48);
                this.richTextBoxSnippetContent.ForeColor = Color.White;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxSnippetContent.Focus();
            this.richTextBoxSnippetContent.SelectAll();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxSnippetContent.Focus();
            this.richTextBoxSnippetContent.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxSnippetContent.Focus();
            this.richTextBoxSnippetContent.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxSnippetContent.Focus();
            this.richTextBoxSnippetContent.Cut();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this._statisticsWindow.ShowStatistics();
        }

        public void EnableButtonNewSnippet()
        {
            this.buttonNewSnippet.Enabled = true;
        }

        private void DisableEditButtons()
        {
            this.cutToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Enabled = false;
            this.selectAllToolStripMenuItem.Enabled = false;
        }

        private void EnableEditButtons()
        {
            this.cutToolStripMenuItem.Enabled = true;
            this.copyToolStripMenuItem.Enabled = true;
            this.pasteToolStripMenuItem.Enabled = true;
            this.selectAllToolStripMenuItem.Enabled = true;
        }

        public void EnableWordWrap(bool isWordWrapEnabled)
        {
            this.richTextBoxSnippetContent.WordWrap = isWordWrapEnabled;
        }

        private void buttonCopySnippet_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBoxSnippetContent.Text, TextDataFormat.UnicodeText);
        }
    }
}
