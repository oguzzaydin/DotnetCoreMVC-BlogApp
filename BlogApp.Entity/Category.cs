using System.Collections.Generic;

namespace BlogApp.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
