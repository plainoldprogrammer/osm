using System;
using System.Windows.Forms;
using ConsoleApp;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;

namespace WindowsFormsApp
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        private DatabaseAccess databaseAccess;
        ToolStripMenuItem menuItemFile;
        ToolStripMenuItem menuItemEdit;
        ToolStripMenuItem menuItemTools;
        ToolStripMenuItem menuItemAbout;
        private const int EM_SETTABSTOPS = 0x00CB;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public MainWindow()
        {
            AllocConsole();
            InitializeComponent();
            InitializeDatabaseAcess();
            InitializeGui();
        }

        private void InitializeDatabaseAcess()
        {
            databaseAccess = new DatabaseAccess();
        }

        private void InitializeGui()
        {
            this.Text = "Osm v0.1 (Alpha)";
            SetTabWidth(this.textBoxSnippetContent, 1);
            InitializeMenuStrip();
            InitializeListBoxCategories();
        }

        private void InitializeMenuStrip()
        {
            menuItemFile = new ToolStripMenuItem("File");
            ToolStripButton itemExit = new ToolStripButton("Exit");
            menuItemFile.DropDownItems.Add(itemExit);
            this.menuStrip.Items.Add(menuItemFile);

            menuItemEdit = new ToolStripMenuItem("File");
            ToolStripButton itemCut = new ToolStripButton("Cut");
            ToolStripButton itemCopy = new ToolStripButton("Copy");
            ToolStripButton itemPaste = new ToolStripButton("Paste");
            menuItemEdit.DropDownItems.Add(itemCut);
            menuItemEdit.DropDownItems.Add(itemCopy);
            menuItemEdit.DropDownItems.Add(itemPaste);
            this.menuStrip.Items.Add(menuItemEdit);

            menuItemTools = new ToolStripMenuItem("Tools");
            ToolStripButton itemOptions = new ToolStripButton("Options");
            menuItemTools.DropDownItems.Add(itemOptions);
            this.menuStrip.Items.Add(menuItemTools);

            menuItemAbout = new ToolStripMenuItem("Help");
            ToolStripButton itemAbout = new ToolStripButton("About");
            menuItemAbout.DropDownItems.Add(itemAbout);
            this.menuStrip.Items.Add(menuItemAbout);

            itemExit.Click += itemExit_Clicked;
            itemAbout.Click += itemAbout_Clicked;
            
        }

        private void InitializeListBoxCategories()
        {
            List<String> categories = databaseAccess.GetCategories();

            foreach (String category in categories)
            {
                this.listBoxCategories.Items.Add(category);
            }

            this.listBoxCategories.SelectedIndex = this.listBoxCategories.Items.Count - 1;
            this.listBoxSnippets.SelectedIndex = this.listBoxSnippets.Items.Count - 1;
        }

        private void listBoxCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            String category = listBoxCategories.SelectedItem.ToString();
            List<String> titles = databaseAccess.GetSnippetTitlesFromACategory(category);
            listBoxSnippets.Items.Clear();

            foreach (String title in titles)
            {
                listBoxSnippets.Items.Add(title);
            }
        }

        private void listBoxSnippets_SelectedValueChanged(object sender, EventArgs e)
        {
            String category = listBoxCategories.SelectedItem.ToString();
            String title = listBoxSnippets.SelectedItem.ToString();

            textBoxSnippetTitle.Text = title;
            textBoxSnippetContent.Text = databaseAccess.GetSnippet(category, title);
        }

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr h, int msg, int wParam, int[] lParam);

        public static void SetTabWidth(TextBox textbox, int tabWidth)
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

        private void itemExit_Clicked(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemAbout_Clicked(Object sender, EventArgs e)
        {
            String version = "0.1 (Alpha)";
            String releaseDate = "2021 April 28";
            String message = $"Osm\nOther Snippet Manager\nVersion: {version}\nRelease Date: {releaseDate}\nDeveloper: PlainOldProgrammer";

            MessageBox.Show(message, "About Osm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
