using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager category = new CategoryManager(new EfCategoryDAL());
        CategoryValidator validate = new CategoryValidator();

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
            
            ValidationResult validation = validate.Validate(p);
            if (validation.IsValid)
            {
                category.Add(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach(var i in validation.Errors)
                {
                    ModelState.AddModelError(i.PropertyName,i.ErrorMessage);
                }
            }
            return View();
        }
    }
}