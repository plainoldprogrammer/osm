using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public partial class Snippet
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public string Title { get; set; }
        public string Snippet1 { get; set; }
        public byte[] Datetime { get; set; }

        public virtual Category Category { get; set; }
    }
}
