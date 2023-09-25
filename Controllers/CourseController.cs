using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{   
    public class CourseController : Controller
    {
        public IActionResult Index()
        {   
            var model = Repository.Aplications;
            return View(model);
        }
        
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            Repository.Add(model);
            return View("Feedback", model);
        }
    }
}