using Microsoft.AspNetCore.Mvc;
using StudentTaskManager.Models;

namespace StudentTaskManager.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>();

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = students.Count + 1;
            students.Add(s);
            return RedirectToAction("Index");
        }
    }
}