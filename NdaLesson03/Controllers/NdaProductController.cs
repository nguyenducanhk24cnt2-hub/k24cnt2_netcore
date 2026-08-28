using Microsoft.AspNetCore.Mvc;
using NdaLesson03.Models;

namespace NdaLesson03.Controllers
{
    [Route("/Danh-sach-san-pham")]
    public class NdaProductController : Controller
    {
        private readonly List<NdaProduct> _Products = new()
        {
                new NdaProduct
            {
                NdaProductId = "MOB-001",
                NdaProductName = "iPhone 15 Pro Max 256GB",
                NdaYearRelease = 2023,
                NdaPrice = 1199.00m
            },
            new NdaProduct
            {
                NdaProductId = "MOB-002",
                NdaProductName = "Samsung Galaxy Z Fold5",
                NdaYearRelease = 2023,
                NdaPrice = 1799.99m
            },
            new NdaProduct
            {
                NdaProductId = "MOB-003",
                NdaProductName = "Xiaomi 14 Ultra 512GB",
                NdaYearRelease = 2024,
                NdaPrice = 1099.50m
            },
            new NdaProduct
            {
                NdaProductId = "TAB-004",
                NdaProductName = "iPad Air 11 inch M2",
                NdaYearRelease = 2024,
                NdaPrice = 599.00m
            },
            new NdaProduct
            {
                NdaProductId = "TAB-005",
                NdaProductName = "Samsung Galaxy Tab S9 FE",
                NdaYearRelease = 2023,
                NdaPrice = 449.99m
            },
            new NdaProduct
            {
                NdaProductId = "WCH-006",
                NdaProductName = "Apple Watch Ultra 2",
                NdaYearRelease = 2023,
                NdaPrice = 799.00m
            },
            new NdaProduct
            {
                NdaProductId = "AUD-007",
                NdaProductName = "AirPods Pro Gen 2 (USB-C)",
                NdaYearRelease = 2023,
                NdaPrice = 249.00m
            },
            new NdaProduct
            {
                NdaProductId = "ACC-008",
                NdaProductName = "Anker MagGo Power Bank 10000mAh",
                NdaYearRelease = 2024,
                NdaPrice = 89.99m
            },
            new NdaProduct
            {
                NdaProductId = "ACC-009",
                NdaProductName = "Baseus GaN5 Pro Fast Charger 65W",
                NdaYearRelease = 2023,
                NdaPrice = 35.50m
            },
                new NdaProduct
            {
                NdaProductId = "ACC-010",
                NdaProductName = "DJI Osmo Mobile 6",
                NdaYearRelease = 2022,
                NdaPrice = 149.00m
            }
        };
        public IActionResult Index()
        {
            return Json(_Products);
        }
        [Route("All")]
        public IActionResult NdaGetAllProduct()
        {
            ViewData["Products"] = _Products;
            return View();
        }
    }
}
