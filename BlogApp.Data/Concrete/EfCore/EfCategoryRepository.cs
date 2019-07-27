using BlogApp.Data.Abstract;
using BlogApp.Entity;
using System;
using System.Linq;

namespace BlogApp.Data.Concrete.EfCore
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private BlogContext context;

        public EfCategoryRepository(BlogContext _context)
        {
            context = _context;
        }
        public Category GetById(int categoryId)
        {
            return context.Categories.FirstOrDefault(p => p.CategoryId == categoryId);
        }

        public IQueryable<Category> GetAll()
        {
            return context.Categories;
        }

        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = context.Categories.FirstOrDefault(p => p.CategoryId == categoryId);
            if (category != null)
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
