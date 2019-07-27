using BlogApp.Data.Abstract;
using BlogApp.Entity;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public class EfBlogRepository : IBlogRepository
    {
        private BlogContext context;
        public EfBlogRepository(BlogContext _context)
        {
            context = _context;
        }
        public Blog GetById(int blogId)
        {
            return context.Blogs.FirstOrDefault(p => p.BlogId == blogId);
        }

        public IQueryable<Blog> GetAll()
        {
            return context.Blogs;
        }

        public void AddBlog(Blog model)
        {
            context.Blogs.Add(model);
            context.SaveChanges();
        }

        public void UpdateBlog(Blog model)
        {
            context.Entry(model).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteBlog(int blogId)
        {
            var blog = context.Blogs.FirstOrDefault(p => p.BlogId == blogId);
            if (blog != null)
            {
                context.Blogs.Remove(blog);
                context.SaveChanges();
            }
        }
    }
}
