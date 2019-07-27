using BlogApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View(categoryRepository.GetAll());
        }
    }
}