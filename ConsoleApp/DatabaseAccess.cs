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

		public List<Category> GetCategories()
		{
			var context = new SnippetsContext();
			List<Category> categories = context.Categories.Select(x => x).ToList<Category>();

			return categories;
		}

		public void CreateSnippet(Snippet snippet)
        {
            var context = new SnippetsContext();
            context.Add<Snippet>(snippet);
            context.SaveChanges();
        }

        public void RemoveSnippet(Snippet snippet)
        {
            var context = new SnippetsContext();
            context.Snippets.Remove(snippet);
            context.SaveChanges();
        }

		public List<Snippet> GetAllSnippetsFromCategory(Category category)
        {
            var context = new SnippetsContext();
            List<Snippet> snippets = context.Snippets.Select(x => x).Where(y => y.Category == category).ToList<Snippet>();
            return snippets;
        }

        public void UpdateSnippet(Snippet snippet)
        {
            var context = new SnippetsContext();
            context.Snippets.Update(snippet);
            context.SaveChanges();
        }
	}
}
