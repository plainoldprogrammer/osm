/*
 * Name:    OSM
 * Author:  Plainoldprogrammer
 * Editor:  Visual Studio 2022 (Community Edition)
 */

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            Console.WriteLine(databaseAccess.GetCategories());
        }
    }
}
