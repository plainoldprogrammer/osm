﻿/*
 * Name:    OSM
 * Author:  Plainoldprogrammer
 * Editor:  Visual Studio 2022 (Community Edition)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ConsoleApp.Models;

namespace ConsoleApp
{
    public class DatabaseAccess
    {
        private SnippetsContext snippetsContext { get; set; }

        public DatabaseAccess()
        {
            this.snippetsContext = new SnippetsContext();
        }

        public void CreateCategory(String categoryName)
        {
            Category category = new Category()
            {
                Category1 = categoryName
            };
            snippetsContext.Add<Category>(category);
            snippetsContext.SaveChanges();
        }

        public void RemoveCategory(Category category)
        {
            var snippetsFromCategory = snippetsContext.Snippets.Select(x => x).Where(y => y.CategoryId == category.Id);
            snippetsContext.Snippets.RemoveRange(snippetsFromCategory);
            snippetsContext.Categories.Remove(category);
            snippetsContext.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = snippetsContext.Categories.Select(x => x).ToList<Category>();
            return categories;
        }

        public void CreateSnippet(Snippet snippet)
        {
            snippetsContext.Add<Snippet>(snippet);
            snippetsContext.SaveChanges();
        }

        public void RemoveSnippet(Snippet snippet)
        {
            snippetsContext.Snippets.Remove(snippet);
            snippetsContext.SaveChanges();
        }

        public List<Snippet> GetAllSnippetsFromCategory(Category category)
        {
            List<Snippet> snippets = this.snippetsContext.Snippets.Select(x => x).Where(y => y.Category == category).ToList<Snippet>();
            return snippets;
        }

        public void UpdateSnippet(Snippet snippet)
        {
            snippetsContext.Snippets.Update(snippet);
            snippetsContext.SaveChanges();
        }

        public String GetDatabasePath()
        {
            String db = snippetsContext.Database.GetDbConnection().DataSource;
            return db;
        }

        public int GetNumberOfSnippets()
        {
            var result = snippetsContext.Snippets.Count();
            return result;
        }

        public int GetNumberOfCategories()
        {
            var result = snippetsContext.Categories.Count();
            return result;
        }
    }
}
