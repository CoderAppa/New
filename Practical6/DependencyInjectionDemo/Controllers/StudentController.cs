using System.Web.Mvc;
using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        public ActionResult Index()
        {
            var students = studentService.GetStudents();
            return View(students);
        }
    }
}
