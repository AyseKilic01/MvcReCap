using BusinessLayer.Concrete;
using DataAccess.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager category = new CategoryManager(new EfCategoryDAL());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = category.GetAllBL();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            category.CategoryAdd(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}