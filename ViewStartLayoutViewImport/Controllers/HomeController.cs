using Microsoft.AspNetCore.Mvc;

namespace ViewStartLayoutViewImport.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //ViewData, ViewBag, TempData
            ViewData["name"] = "Filankes";
            ViewBag.age = 20;
            TempData["address"] = "Sumgayit";
            //Index-den About-un View-na Data Gondermek (TempData ile)
            int sngid = 10;
            TempData["ID"] = sngid;
            return RedirectToAction("About");
        }
        public IActionResult About()
        {
            int id = Convert.ToInt32(TempData["ID"]);

            return View();
        }
    }
}
