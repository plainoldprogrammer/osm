using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public partial class Snippets
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Snippet { get; set; }
        public string Category { get; set; }
        public byte[] Datetime { get; set; }
    }
}
