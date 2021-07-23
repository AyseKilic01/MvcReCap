using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class StatisticController : Controller
    {
        CategoryManager category = new CategoryManager(new EfCategoryDAL());
        CategoryValidator validate = new CategoryValidator();
        // GET: Statistic
        public ActionResult Index()
        {
            var categoryvalues = category.GetCount();
            return View(categoryvalues);
        }
        [HttpPost]
        public ActionResult GetCCount()
        {
            var categoryvalues = category.GetCount();
            return View(categoryvalues);
        }
    }
}