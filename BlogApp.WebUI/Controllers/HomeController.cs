using BlogApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IBlogRepository blogRepository;
        public HomeController(IBlogRepository repository)
        {
            blogRepository = repository;
        }
        public IActionResult Index()
        {
            return View(blogRepository.GetAll());
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}