using Microsoft.AspNetCore.Mvc;
using Contract_Monthly_Claim_System_ST10077892.Models;

namespace Contract_Monthly_Claim_System_ST10077892.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult Index()
        {
            var lecturers = new List<Lecturer>();
            return View(lecturers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Lecturer lecturer)
        {
            if (ModelState.IsValid)
            {
                // Simulate an asynchronous operation (e.g., saving to a database)
                await Task.Delay(1); // Replace this with actual async database call
                return RedirectToAction(nameof(Index));
            }
            return View(lecturer);
        }


        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
