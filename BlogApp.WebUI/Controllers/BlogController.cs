using BlogApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository blogRepository;

        public BlogController(IBlogRepository _blogRepository)
        {
            blogRepository = _blogRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View(blogRepository.GetAll());
        }
    }
}