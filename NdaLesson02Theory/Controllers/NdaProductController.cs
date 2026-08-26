using Microsoft.AspNetCore.Mvc;
using NdaLesson02Theory.Models;
namespace NdaLesson02Theory.Controllers
{
    public class NdaProductController : Controller
    {
        public IActionResult NdaIndex()
        {
            ViewBag.name ="Nguyễn Đức Anh";
            ViewData["productHD"] = "Laprop msi gf63 thin";
            TempData["UNI"] = "Đại học Nguyễn Trãi";
            return View();
        }
        public IActionResult GetProduct()
        {
            NdaProduct ndaproduct = new NdaProduct() 
            {
                ProductID = "2410900002",
                ProductName = "Nguyễn Đức Anh",
                YearRelease = 2003,
                Price = 10000000
            };
            ViewBag.product = ndaproduct;
            ViewData["Product"] = ndaproduct;
            
            return View("Product");
        }
    }
}
