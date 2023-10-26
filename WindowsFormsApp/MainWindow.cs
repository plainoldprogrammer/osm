/*
 * Name:    OSM
 * Author:  Plainoldprogrammer
 * Editor:  Visual Studio 2022 (Community Edition)
 */

using System;
using System.Windows.Forms;
using ConsoleApp;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using ConsoleApp.Models;

namespace WindowsFormsApp
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        private const string VERSION = "0.5 (Alpha)";
        private const string RELEASE_DATE = "2023 August 11";

        private DatabaseAccess databaseAccess;
        private const int EM_SETTABSTOPS = 0x00CB;

        private CreateCategoryWindow createCategoryWindow;
        private OptionsWindow optionsWindow;
        private StatisticsWindow statisticsWindow;

        /*
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        */

        public MainWindow()
        {
            /*
            if (Debugger.IsAttached)
            {
                AllocConsole();
            }
            */

            InitializeComponent();
            InitializeDatabaseAcess();

            createCategoryWindow = new CreateCategoryWindow(this, this.databaseAccess);
            optionsWindow = new OptionsWindow(this, this.databaseAccess);
            statisticsWindow = new StatisticsWindow(this, this.databaseAccess);

            InitializeGui();

            this.CenterToScreen();
        }

        private void InitializeDatabaseAcess()
        {
            databaseAccess = new DatabaseAccess();
        }

        private void InitializeGui()
        {
            this.Text = $"Osm v{VERSION}";
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

            this.optionsWindow.SetFontSize(Int32.Parse(applicationFontSizeOnConfig));

            var applicationFontFamilyOnConfig = WindowsFormsApp.Properties.Settings.Default["ApplicationFontFamily"].ToString();
            this.optionsWindow.SetFontFamily(applicationFontFamilyOnConfig);

            InitializeListBoxCategories();
            InitializeListBoxSnippets();

            if (this.listBoxCategories.Items.Count == 0)
            {
                this.buttonRemoveCategory.Enabled = false;
                this.buttonNewSnippet.Enabled = false;
                this.textBoxSnippetTitle.Enabled = false;
                this.richTextBoxSnippetContent.Enabled = false;
            }

            exitToolStripMenuItem.Click += ItemExit_Clicked;
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

            List<Category> categories = this.databaseAccess.GetCategories();

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
                List<Snippet> snippets = this.databaseAccess.GetAllSnippetsFromCategory(selectedCategory);

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
                }
            }
        }

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr h, int msg, int wParam, int[] lParam);

        public static void SetTabWidth(RichTextBox textbox, int tabWidth)
        {
            Graphics graphics = textbox.CreateGraphics();
            var characterWidth = (int)graphics.MeasureString("M", textbox.Font).Width;
            SendMessage
                (textbox.Handle
                , EM_SETTABSTOPS
                , 1
                , new int[] { tabWidth * characterWidth }
                );
        }

        private void ItemExit_Clicked(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = $"Osm\nOther Snippet Manager\nVersion: {VERSION}\nRelease Date: {RELEASE_DATE}\nDeveloper: PlainOldProgrammer";
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
            this.createCategoryWindow.Show();
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

                        this.listBoxSnippets.Enabled = false;
                        this.textBoxSnippetTitle.Enabled = false;
                        this.richTextBoxSnippetContent.Enabled = false;

                        this.textBoxSnippetTitle.Text = "";
                        this.richTextBoxSnippetContent.Text = "";
                    }

                    this.databaseAccess.RemoveCategory(selectedCategory);
                }
            }
        }

        private void buttonNewSnippet_Click(object sender, EventArgs e)
        {
            this.richTextBoxSnippetContent.Text = "";
            string titleOfNewSnippet = "New Snippet";

            Category selectedCategory = this.listBoxCategories.SelectedItem as Category;
            Snippet snippet = new Snippet()
            {
                Title = titleOfNewSnippet,
                CategoryId = selectedCategory.Id,
                Datetime = BitConverter.GetBytes(DateTime.Now.Ticks)
            };

            this.databaseAccess.CreateSnippet(snippet);

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

            this.textBoxSnippetTitle.Focus();
        }

        private void buttonRemoveSnippet_Click(object sender, EventArgs e)
        {
            if (this.listBoxSnippets.Items.Count > 0)
            {
                Snippet selectedSnippet = this.listBoxSnippets.SelectedItem as Snippet;
                int index = this.listBoxSnippets.SelectedIndex;
                this.databaseAccess.RemoveSnippet(selectedSnippet);
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

                    this.textBoxSnippetTitle.Text = "";
                    this.richTextBoxSnippetContent.Text = "";
                }

                Console.WriteLine($"Selected item at the end of remove snippet operation is: {this.listBoxSnippets.SelectedIndex}");
            }
        }

        private void textBoxSnippetTitle_TextChanged(object sender, EventArgs e)
        {
            if (listBoxSnippets.Items.Count > 0)
            {
                string title = ((TextBox)sender).Text;
                Snippet selectedSnippet = this.listBoxSnippets.SelectedItem as Snippet;
                selectedSnippet.Title = title;
                databaseAccess.UpdateSnippet(selectedSnippet);
            }
        }

        private void textBoxSnippetContent_TextChanged(object sender, EventArgs e)
        {
            string content = ((TextBox)sender).Text;
            Snippet selectedSnippet = this.listBoxSnippets.SelectedItem as Snippet;

            if (selectedSnippet is not null)
            {
                selectedSnippet.Snippet1 = content;
                this.databaseAccess.UpdateSnippet(selectedSnippet);
            }
        }

        public void EnableRemoveCategoryButton()
        {
            this.buttonRemoveCategory.Enabled = true;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.optionsWindow.Show();
        }

        public void SetFont(string fontFamily, int fontSize)
        {
            this.richTextBoxSnippetContent.Font = new Font(fontFamily, fontSize);
        }

        public void SetFontSize(int fontSize)
        {
            this.richTextBoxSnippetContent.Font = new Font(this.richTextBoxSnippetContent.Font.FontFamily, fontSize);
        }

        private void richTextBoxSnippetContent_TextChanged(object sender, EventArgs e)
        {
            string content = ((RichTextBox)sender).Text;
            Snippet selectedSnippet = this.listBoxSnippets.SelectedItem as Snippet;

            if (selectedSnippet is not null)
            {
                selectedSnippet.Snippet1 = content;
                this.databaseAccess.UpdateSnippet(selectedSnippet);
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
            this.richTextBoxSnippetContent.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxSnippetContent.Cut();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.statisticsWindow.ShowStatistics();
        }

        public void EnableButtonNewSnippet()
        {
            this.buttonNewSnippet.Enabled = true;
        }
    }
}
