using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Models;

namespace ConsoleApp
{
    public class DatabaseAccess
    {
        public List<string> GetCategories()
        {
            var context = new snippetsContext();
            List<string> categories = context.Categories.Select(x => x.Category).ToList();

            return categories;
        }

        public List<string> GetSnippetTitlesFromACategory(string category)
        {
            var context = new snippetsContext();
            List<string> titles = context.Snippets.Where(x => x.Category == category).Select(x => x.Title).ToList();

            return titles;
        }

        public string GetSnippet(string category, string title)
        {
            var context = new snippetsContext();
            string snippet = context.Snippets.Where(x => x.Category == category && x.Title == title).Select(x => x.Snippet).FirstOrDefault();

            return snippet.Replace("\n", "\r\n");
        }

        public void CreateSnippet(string category, string title, string code)
        {
            var context = new snippetsContext();

            Snippets snippet = new Snippets();
            snippet.Category = category;
            snippet.Title = title;
            snippet.Snippet = code;

            context.Add(snippet);
            context.SaveChanges();
        }

        public void RemoveSnippet(string category, string title, string code)
        {
            var context = new snippetsContext();

            Snippets snippet = new Snippets();
            snippet.Id = context.Snippets.Where(x => x.Category.Equals(category) && x.Title.Equals(title)).Select(x => x.Id).FirstOrDefault();
            snippet.Category = category;
            snippet.Title = title;
            snippet.Snippet = code;

            context.Snippets.Remove(snippet);
            context.SaveChanges();
        }
    }
}
