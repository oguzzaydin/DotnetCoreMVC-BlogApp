﻿using System;

namespace BlogApp.Entity
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsApproved { get; set; }
        public bool isHome { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
