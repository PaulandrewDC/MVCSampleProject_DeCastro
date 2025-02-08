using Microsoft.AspNetCore.Mvc;

namespace MVCSampleProject_DeCastro.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }
    }
}
