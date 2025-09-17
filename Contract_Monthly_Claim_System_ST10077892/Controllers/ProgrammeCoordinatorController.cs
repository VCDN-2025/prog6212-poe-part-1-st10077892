using Contract_Monthly_Claim_System_ST10077892.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_Claim_System_ST10077892.Controllers
{
    public class ProgrammeCoordinatorController : Controller
    {
        public IActionResult Index()
        {
            var programmeCoordinator = new List<ProgrammeCoordinator>();
            return View(programmeCoordinator);
        }

        public IActionResult Create()
        {
            return View();
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
