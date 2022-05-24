using Microsoft.AspNetCore.Mvc;

namespace PraktikaImport.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
