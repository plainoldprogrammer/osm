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
using Osm;
using ConsoleApp.Models;

namespace WindowsFormsApp
{
	public partial class MainWindow : System.Windows.Forms.Form
	{
		private const string VERSION = "0.3 (Alpha)";
		private const string RELEASE_DATE = "2023 March 09";

		private DatabaseAccess databaseAccess;
		ToolStripMenuItem menuItemFile;
		ToolStripMenuItem menuItemEdit;
		ToolStripMenuItem menuItemTools;
		ToolStripMenuItem menuItemAbout;
		private const int EM_SETTABSTOPS = 0x00CB;

		private CreateCategoryWindow createCategoryWindow;

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		public MainWindow()
		{
			AllocConsole();
			InitializeComponent();
			InitializeDatabaseAcess();
			InitializeGui();
			createCategoryWindow = new CreateCategoryWindow(this, this.databaseAccess);
		}

		private void InitializeDatabaseAcess()
		{
			databaseAccess = new DatabaseAccess();
		}

		private void InitializeGui()
		{
			this.Text = $"Osm v{VERSION}";
			SetTabWidth(this.textBoxSnippetContent, 1);
			InitializeMenuStrip();
			// ConfigureListBoxSnippets();
			// ConfigureListBoxCategories();
			InitializeListBoxCategories();
			InitializeListBoxSnippets();

			if (this.listBoxCategories.Items.Count == 0)
			{
				this.buttonRemoveCategory.Enabled = false;
				this.textBoxSnippetTitle.Enabled = false;
				this.textBoxSnippetContent.Enabled = false;
			}
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

			itemExit.Click += ItemExit_Clicked;
			itemAbout.Click += ItemAbout_Clicked;
		}

		private void ConfigureListBoxCategories()
		{
			this.listBoxCategories.DrawMode = DrawMode.OwnerDrawFixed;
			this.listBoxCategories.DrawItem += new DrawItemEventHandler(listBoxCategories_DrawItem);
		}

		private void ConfigureListBoxSnippets()
		{
			this.listBoxSnippets.DrawMode = DrawMode.OwnerDrawFixed;
			this.listBoxSnippets.DrawItem += new DrawItemEventHandler(listBoxSnippets_DrawItem);
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
			this.textBoxSnippetContent.Select(0, 0);
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
			}

			if (listBoxCategories.Items.Count == 0 || listBoxSnippets.Items.Count == 0)
			{
				this.buttonRemoveSnippet.Enabled = false;
				this.textBoxSnippetTitle.Enabled = false;
				this.textBoxSnippetContent.Enabled = false;
			}
			else
			{
				this.buttonRemoveSnippet.Enabled = true;
				this.textBoxSnippetTitle.Enabled = true;
				this.textBoxSnippetContent.Enabled = true;
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
					this.textBoxSnippetContent.Text = selectedSnippet.Snippet1;
				}
			}
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

		private void ItemExit_Clicked(Object sender, EventArgs e)
		{
			this.Close();
		}

		private void ItemAbout_Clicked(Object sender, EventArgs e)
		{
			string message = $"Osm\nOther Snippet Manager\nVersion: {VERSION}\nRelease Date: {RELEASE_DATE}\nDeveloper: PlainOldProgrammer";
			MessageBox.Show(message, "About Osm", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void listBoxCategories_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			e.Graphics.DrawIcon(new Icon("icons/folder.ico", 16, 16), e.Bounds.X, e.Bounds.Y);

			Rectangle textRectangle = e.Bounds;
			textRectangle.X += 18;

			e.Graphics.DrawString(listBoxCategories.Items[e.Index].ToString(),
				e.Font, Brushes.Black, textRectangle, StringFormat.GenericDefault);

			e.DrawFocusRectangle();
		}

		private void listBoxSnippets_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			e.Graphics.DrawIcon(new Icon("icons/file.ico", 16, 16), e.Bounds.X, e.Bounds.Y);

			Rectangle textRectangle = e.Bounds;
			textRectangle.X += 18;

			e.Graphics.DrawString(listBoxSnippets.Items[e.Index].ToString(),
				e.Font, Brushes.Black, textRectangle, StringFormat.GenericDefault);

			e.DrawFocusRectangle();
		}

		private void buttonNewCategory_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			this.createCategoryWindow.Show();
			this.buttonNewSnippet.Enabled = true;
			this.textBoxSnippetTitle.Enabled = true;
			this.textBoxSnippetContent.Enabled = true;
		}

		private void buttonRemoveCategory_Click(object sender, EventArgs e)
		{
			if (this.listBoxCategories.Items.Count > 0)
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

					this.textBoxSnippetTitle.Enabled = false;
					this.textBoxSnippetContent.Enabled = false;
				}

				this.databaseAccess.RemoveCategory(selectedCategory);
			}
		}

		private void buttonNewSnippet_Click(object sender, EventArgs e)
		{
			this.textBoxSnippetContent.Text = "";
			string titleOfNewSnippet = "New Snippet";

			Category selectedCategory = this.listBoxCategories.SelectedItem as Category;
			Snippet snippet = new Snippet()
			{
				Title = titleOfNewSnippet,
				CategoryId = selectedCategory.Id,
				Datetime = BitConverter.GetBytes(DateTime.Now.Ticks)
			};

			this.databaseAccess.CreateSnippet(snippet);

			this.listBoxSnippets.Items.Add(snippet);
			this.listBoxSnippets.SelectedIndex = this.listBoxSnippets.Items.Count - 1;
			this.textBoxSnippetTitle.Text = titleOfNewSnippet;

			if (!this.textBoxSnippetTitle.Enabled && !this.textBoxSnippetContent.Enabled)
			{
				this.textBoxSnippetTitle.Enabled = true;
				this.textBoxSnippetContent.Enabled = true;
			}

			if (this.buttonRemoveSnippet.Enabled == false)
			{
				this.buttonRemoveSnippet.Enabled = true;
			}
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
				this.listBoxSnippets.SelectedIndex = index;

				if (this.listBoxSnippets.Items.Count == 0)
				{
					this.textBoxSnippetTitle.Enabled = false;
					this.textBoxSnippetContent.Enabled = false;
					this.buttonRemoveSnippet.Enabled = false;
				}
			}
		}

		private void textBoxSnippetTitle_TextChanged(object sender, EventArgs e)
		{
			string title = ((TextBox)sender).Text;
			Snippet selectedSnippet = this.listBoxSnippets.SelectedItem as Snippet;
			selectedSnippet.Title = title;
			databaseAccess.UpdateSnippet(selectedSnippet);
		}

		private void textBoxSnippetContent_TextChanged(object sender, EventArgs e)
		{
			string content = ((TextBox)sender).Text;
			Snippet selectedSnippet = this.listBoxSnippets.SelectedItem as Snippet;
			selectedSnippet.Snippet1 = content;
			this.databaseAccess.UpdateSnippet(selectedSnippet);
		}

		public void EnableRemoveCategoryButton()
		{
			this.buttonRemoveCategory.Enabled = true;
		}
	}
}
