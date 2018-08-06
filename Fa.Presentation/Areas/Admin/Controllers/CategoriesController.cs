using Fa.DataAccessLayer;
using Fa.Model.Model;
using Fa.Service;
using System.Web.Mvc;

namespace Fa.Presentation.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoryService _service = new CategoryService(new CategoryRepository());
        // GET: Admin/Categories
        public ActionResult Index()
        {
            return View(_service.GetCategories());
        }

        
        public ActionResult Create()
        {
            return View(new Category());
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            _service.Insert(category);
            _service.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
                var category = _service.GetCategory(id);
            if (category == null)
                return RedirectToAction("Index");
                return View(category);
        }

        public ActionResult Edit(int id)
        {
            var category = _service.GetCategory(id);
            if (category != null)
            {
                return View(category);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            category.CategoryId = id;
            _service.Update(category);
            _service.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(_service.GetCategory(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, Category category)
        {
            _service.Delete(id);
            _service.Save();
            return RedirectToAction("Index");
        }
    }
}