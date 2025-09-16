using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_Claim_System_ST10077892.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        //public IActionResult Edit()
        //{
        //    return View();
        //}

        //public IActionResult Details()
        //{
        //    return View();
        //}

        //public IActionResult Delete()
        //{
        //    return View();
        //}
    }
}
