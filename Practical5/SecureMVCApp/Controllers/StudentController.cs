using System.Web.Mvc;

namespace SecureMVCApp.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }
    }
}
