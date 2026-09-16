using Microsoft.AspNetCore.Mvc;
using NdaLesson08.Models;

namespace NdaLesson08.Controllers
{
    public class NdaMemberController : Controller
    {
        private static List<Models.NdaMember> _Members = new List<Models.NdaMember>
        {
            new NdaMember
            {
                NdaMemberId = Guid.NewGuid().ToString(),
                NdaUserName = "nguyena",
                NdaPassword = "Password123!",
                NdaFullName = "Nguyễn Đức Anh",
                NdaEmail = "nguyenducanh@gmail.com"
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
            return View(_Members);
        }
        [HttpGet]
        public IActionResult NdaCreate()
        {
            var member = new NdaMember();
            return View(member);
        }
        [HttpPost]
        public IActionResult NdaCreate(NdaMember member)
        {
            member.NdaMemberId = Guid.NewGuid().ToString();
            _Members.Add(member);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult NdaEdit(string id)
        {
            var member = _Members.Where(m => m.NdaMemberId == id).FirstOrDefault();

            return View(member);
        }
        [HttpPost]
        public IActionResult NdaEdit(string id, NdaMember member)
        {
            for (int i = 0; i < _Members.Count; i++)
            {
                if (_Members[i].NdaMemberId == member.NdaMemberId)
                {
                    _Members[i].NdaUserName = member.NdaUserName;
                    _Members[i].NdaPassword = member.NdaPassword;
                    _Members[i].NdaFullName = member.NdaFullName;
                    _Members[i].NdaEmail = member.NdaEmail;
                    return RedirectToAction("Index");
                }
            }
            return View(member);
        }
        [HttpGet]
        public IActionResult NdaDetails(string id)
        {
            var member = _Members.Where(x => x.NdaMemberId == id).FirstOrDefault();
            return View(member);
        }
        [HttpGet]
        public IActionResult NdaDelete(string id)
        {
            var member = _Members.Where(x => x.NdaMemberId == id).FirstOrDefault();
            return View(member);
        }
        [HttpPost]
        public IActionResult NdaDeleted(string id, NdaMember member)
        {
            foreach (var item in _Members)
            {
                if (item.NdaMemberId == member.NdaMemberId)
                {
                    _Members.Remove(item);
                    return RedirectToAction("Index");
                }
            }
            return View(member);
        }
    }
}
