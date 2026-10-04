using Microsoft.AspNetCore.Mvc;

namespace HelloWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            ViewBag.Message = "Welcome " + name;
            return View();
        }
    }
}
