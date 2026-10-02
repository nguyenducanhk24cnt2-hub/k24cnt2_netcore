using Microsoft.AspNetCore.Mvc;

namespace NdaLesson13layout.Controllers
{
    public class NdaProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string keyword)
        {
            ViewData["Keyword"] = keyword;
            return View();
        }
        public IActionResult Hots() {
            return View();
        }
    }
}

