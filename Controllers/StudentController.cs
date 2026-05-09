using Microsoft.AspNetCore.Mvc;

namespace StudentTaskManager.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
