using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NguyenDucAnh2410900002Exam.Models;

namespace NguyenDucAnh2410900002Exam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult NdaAbout()
        {
            ViewBag.MaSV = "2410900002";
            ViewBag.HoTen = "Nguyễn Đức Anh";
            ViewBag.Lop = "K24CNT2";
            ViewBag.NgaySinh = "28/10/2003";
            ViewBag.Email = "nguyenducanh12a7nhnd@gmail.com";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
