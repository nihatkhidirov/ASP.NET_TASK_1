using Microsoft.AspNetCore.Mvc;

namespace ViewStartLayoutViewImport.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
