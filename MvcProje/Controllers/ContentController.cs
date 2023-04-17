using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}
