using System.Linq;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository _blogRepository;
        private ICategoryRepository _categoryRepository;

        public BlogController(IBlogRepository blogRepository, ICategoryRepository categoryRepository)
        {
            _blogRepository = blogRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index(int? id, string q)
        {
            var query = _blogRepository.GetAll().Where(i => i.IsApproved);
            if (id != null)
                query = query.Where(p => p.CategoryId == id);
            if (!string.IsNullOrEmpty(q))
                query = query.Where(i => i.Name.Contains(q) || i.Description.Contains(q) || i.Body.Contains(q));
               
            return View(query.OrderByDescending(x => x.Date));
        }
        public IActionResult List()
        {
            return View(_blogRepository.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Blog entity)
        {
            if (ModelState.IsValid)
            {
                _blogRepository.AddBlog(entity);
                return RedirectToAction("List");
            }
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");
            return View(entity);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");
            return View(_blogRepository.GetById(id));
        }

        public IActionResult Edit(Blog entity)
        {
            if (ModelState.IsValid)
            {
                _blogRepository.UpdateBlog(entity);
                TempData["message"] = $"{entity.Name} güncellendi";
                return RedirectToAction("List");
            }
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");
            return View(entity);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_blogRepository.GetById(id));
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _blogRepository.DeleteBlog(id);
            TempData["message"] = $"{id} numaralı kayıt silindi";
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_blogRepository.GetById(id));
        }
    }
}