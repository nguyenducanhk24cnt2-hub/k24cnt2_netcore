using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NdaLesson08.Models;

namespace NdaLesson08.Controllers
{
    public class NdaHomeController : Controller
    {
        private readonly ILogger<NdaHomeController> _logger;

        public NdaHomeController(ILogger<NdaHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NdaIndex()
        {
            return View();
        }

        public IActionResult NdaPrivacy()
        {
            return View();
        }
        public IActionResult NdaAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
