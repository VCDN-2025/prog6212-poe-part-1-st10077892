using Microsoft.AspNetCore.Mvc;
using Contract_Monthly_Claim_System_ST10077892.Models;

namespace Contract_Monthly_Claim_System_ST10077892.Controllers
{
    public class SupportingDocumentsController : Controller
    {
        public IActionResult Index()
        {
            var supportingDocument = new List<SupportingDocument>();
            return View(supportingDocument);
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
