﻿using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public partial class Categories
    {
        public long Id { get; set; }
        public string Category { get; set; }
        public byte[] Datetime { get; set; }
    }
}
