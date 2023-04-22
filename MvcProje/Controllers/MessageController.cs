using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Controllers
{
    public class MessageController : Controller
    {
        MessageManager cm = new MessageManager(new EfMessageDal());
        public IActionResult Inbox()
        {
            var messagelist = cm.GetList();
            return View(messagelist);
        }
    }
}
