using System;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			DatabaseAccess databaseAccess = new DatabaseAccess();
			Console.WriteLine(databaseAccess.GetSnippetsTitles());
		}

	}
}
