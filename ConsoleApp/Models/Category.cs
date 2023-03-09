using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public partial class Category
    {
        public Category()
        {
            Snippets = new HashSet<Snippet>();
        }

        public long Id { get; set; }
        public string Category1 { get; set; }
        public byte[] Datetime { get; set; }

        public virtual ICollection<Snippet> Snippets { get; set; }
    }
}
