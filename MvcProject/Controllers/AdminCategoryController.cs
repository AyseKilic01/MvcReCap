using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryManager category = new CategoryManager(new EfCategoryDAL());
        CategoryValidator validate = new CategoryValidator();

        public ActionResult Index()
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
                foreach (var i in validation.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteCategory(int id)
        {
            var categoryvalue = category.GetByID(id);
            category.Delete(categoryvalue);
            //redirectto ile başka bir view e yönlendirme yapabilirsin.
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var categoryvalue = category.GetByID(id);
            category.Update(categoryvalue);
            //redirectto ile başka bir view e yönlendirme yapabilirsin.
            return View(categoryvalue);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category categoryx)
        {
            category.Update(categoryx);
            return RedirectToAction("Index");
        }
    }
}