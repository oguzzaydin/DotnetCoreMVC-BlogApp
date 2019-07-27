using System.Linq;
using BlogApp.Entity;

namespace BlogApp.Data.Abstract
{
    public interface IBlogRepository
    {
        Blog GetById(int blogId);
        IQueryable<Blog> GetAll();
        void AddBlog(Blog model);
        void UpdateBlog(Blog model);
        void DeleteBlog(int blogId);
    }
}
