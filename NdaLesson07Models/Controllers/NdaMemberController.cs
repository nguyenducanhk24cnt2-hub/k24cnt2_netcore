using Microsoft.AspNetCore.Mvc;
using NdaLesson07Models.Models.DataModels;
namespace NdaLesson07Models.Controllers
{
    public class NdaMemberController : Controller
    {
        protected static List<NdaMember> _members = new List<NdaMember>
        {
            new NdaMember
            {
                NdaMemberId = Guid.NewGuid().ToString(),
                NdaUserName = "nguyena",
                NdaPassword = "Password123!",
                NdaFullName = "Nguyễn Văn A",
                NdaEmail = "nguyenvana@example.com"
            },
            new NdaMember
            {
                NdaMemberId = Guid.NewGuid().ToString(),
                NdaUserName = "tranb",
                NdaPassword = "Password123!",
                NdaFullName = "Trần Thị B",
                NdaEmail = "tranthib@example.com"
            },
            new NdaMember
            {
                NdaMemberId = Guid.NewGuid().ToString(),
                NdaUserName = "lec",
                NdaPassword = "Password123!",
                NdaFullName = "Lê Hoàng C",
                NdaEmail = "lehoangc@example.com"
            },
            new NdaMember
            {
                NdaMemberId = Guid.NewGuid().ToString(),
                NdaUserName = "phamd",
                NdaPassword = "Password123!",
                NdaFullName = "Phạm Minh D",
                NdaEmail = "phamminhd@example.com"
            },
            new NdaMember
            {
                NdaMemberId = Guid.NewGuid().ToString(),
                NdaUserName = "hoange",
                NdaPassword = "Password123!",
                NdaFullName = "Hoàng Thu E",
                NdaEmail = "hoangthue@example.com"
            }
        };
        public IActionResult Index()
        {
            return View(_members);
        }
        public IActionResult GetMember()
        {
            var member = new NdaMember
            {
                NdaMemberId = Guid.NewGuid().ToString(),
                NdaUserName = "ND Anh",
                NdaPassword = "password123",
                NdaFullName = "Nguyen duc anh",
                NdaEmail = "ducanh@gmail.com"
            };
            //ViewBag.Member = member;
            return View(member);
        }
        public IActionResult GetMembers()
        {
            ViewBag.Members = _members;
            return View();

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NdaMember member)
        {
            if (ModelState.IsValid)
            {
                member.NdaMemberId = Guid.NewGuid().ToString();
                _members.Add(member);
                return RedirectToAction("Index");
            }
            return View(member);
        }
    }

}
