using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var context = new snippets_copyContext();
			List<Snippets> snippets = context.Snippets.Select(x => x).OrderBy(x => x.Title).ToList();

			foreach (var snippet in snippets)
			{
				Console.WriteLine(snippet.Title);
			}
		}
	}
}
