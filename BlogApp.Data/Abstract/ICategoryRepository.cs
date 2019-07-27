using System.Linq;
using BlogApp.Entity;

namespace BlogApp.Data.Abstract
{
    public interface ICategoryRepository
    {
        Category GetById(int categoryId);
        IQueryable<Category> GetAll();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryId);
    }
}
