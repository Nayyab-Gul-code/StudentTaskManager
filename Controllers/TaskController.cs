using Microsoft.AspNetCore.Mvc;
using StudentTaskManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentTaskManager.Controllers
{
    public class TaskController : Controller
    {
        static List<TaskItem> tasks = new List<TaskItem>();

        public IActionResult Index()
        {
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskItem t)
        {
            t.Id = tasks.Count + 1;
            tasks.Add(t);
            return RedirectToAction("Index");
        }

        public IActionResult Complete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
            }
            return RedirectToAction("Index");
        }
    }
}