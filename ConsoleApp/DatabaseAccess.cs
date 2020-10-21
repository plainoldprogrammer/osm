﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ConsoleApp.Models;

namespace ConsoleApp
{
    public class DatabaseAccess
    {
        public  List<String> GetCategories()
        {
            List<String> categories = new List<String>();

            var context = new snippetsContext();
            List<String> allSnippetCategories = context.Categories.Select(x => x.Category).ToList();

            foreach (String category in allSnippetCategories)
            {
                categories.Add(category);
            }

            return categories;
        }

        public String GetSnippetsTitles()
        {
            String titles = "";

            var context = new snippetsContext();
            List<Snippets> snippets = context.Snippets.Select(x => x).OrderBy(x => x.Title).ToList();

            foreach (var snippet in snippets)
            {
                titles += snippet.Title + "\r\n";
            }

            return titles;
        }

        public List<String> GetSnippetTitlesFromACategory(String category)
        {
            var context = new snippetsContext();
            List<String> titles = context.Snippets.Where(x => x.Category == category).Select(x => x.Title).ToList();

            return titles;
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

        public void EmptySnippetsTable()
        {
            var context = new snippetsContext();
            var snippets = context.Snippets.Select(x => x);

            context.Snippets.RemoveRange(snippets);
            context.SaveChanges();
        }
    }
}
