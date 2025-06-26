# OSM

**OSM** (Other Snippet Manager) is a *C# (WinForms)* clon from my project YASM (Yet Another Snippet Manager) replacing C++ and raw SQL queries with C# and Entity Framework.

<img src="https://raw.githubusercontent.com/plainoldprogrammer/osm/master/screenshots/screenshot-main-window.png" width="745" height="442">

---

### Capabilities

* Read snippets from an existing db file.
* Store categories and snnipets automatically in an internal db.
* Customize the UI through the options dialog.

---

### Version History
**Version 0.5 (Alpha)**
* It's possible to select the theme, font and size in the options window.
* Enabled the cut, copy, paste and select all options.
* Values on the options window are stored in the application settings.
* Introduced a new statistics windows to show a brief report of the snippets.
* The application default size has been adjusted to be more productive.
* The application is centered at launch time.
* Fixed bugs when closing the options window.
* Fixed bugs related to the state of the categories and snippet buttons.

**Version 0.4 (Alpha)**
* First version that is capable to be published and used (as beta, not yet in production).
* Manually menu items has been replaces with items added using the VS designer.
* Options dialog has been added to configure it.
* Fixed a problem that causes to not render correctly the categories and snippets related icons.

**Version 0.3 (Alpha)**
* Most of the internal snippet behavior occurs using EF.
* Icons for categories and snippets has been disable due to a rendering issue.
* It's possible to create categories.
* It's possible to remove categories.
* It's possible to create snippets.
* It's possible to remove snippets.
* It's possible to edit the title and the content of the snippet.
* Enabling saving and editing of categories and snippets in the DB.

**Version 0.2 (Alpha)**
* Upgraded to .NET 5
* Each category has a folder icon to make more intuitive the GUI.
* Each snippet has a file icon to make more intuitive the GUI.

**Version 0.1 (Alpha)**
* Read snippets from an existing db file.
* Navigation through arrow keys in the snippet list.
