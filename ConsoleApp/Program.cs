using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            databaseAccess.CreateSnippet("C", "Hello World", "printf(\"%s\", \"hello world\")");
        }
    }
}
