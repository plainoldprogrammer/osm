/*
 * Name:    OSM
 * Author:  Plainoldprogrammer
 * Editor:  Visual Studio 2022 (Community Edition)
 */

using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Models;

namespace ConsoleApp
{
    public class DatabaseAccess
    {
        public List<Category> GetCategories()
        {
            var context = new SnippetsContext();
            List<Category> categories = context.Categories.Select(x => x).ToList<Category>();

            return categories;
        }

        public void CreateCategory(string categoryName)
        {
            var context = new SnippetsContext();
            Category category = new Category()
            {
                Category1 = categoryName
            };
            context.Add<Category>(category);
            context.SaveChanges();
        }

        public void RemoveCategory(Category category)
        {
            var context = new SnippetsContext();
            context.Remove<Category>(category);
            context.SaveChanges();
        }

        public List<string> GetSnippetTitlesFromACategory(string category)
        {
            var context = new SnippetsContext();
            List<string> titles = context.Snippets.Where(x => x.Category == category).Select(x => x.Title).ToList();

            return titles;
        }

        public string GetSnippet(string category, string title)
        {
            var context = new SnippetsContext();
            string snippet = context.Snippets.Where(x => x.Category == category && x.Title == title).Select(x => x.Snippet1).FirstOrDefault();

            return snippet.Replace("\n", "\r\n");
        }

        public void CreateSnippet(Snippet snippet)
        {
            var context = new SnippetsContext();
            context.Add(snippet);
            context.SaveChanges();
        }

        public void RemoveSnippet(string category, string title, string code)
        {
            var context = new SnippetsContext();

            Snippet snippet = new Snippet();
            snippet.Id = context.Snippets.Where(x => x.Category.Equals(category) && x.Title.Equals(title)).Select(x => x.Id).FirstOrDefault();
            snippet.Category = category;
            snippet.Title = title;
            snippet.Snippet1 = code;

            context.Snippets.Remove(snippet);
            context.SaveChanges();
        }
    }
}
