using Microsoft.AspNetCore.Mvc;
using NdaLesson04Lab.Models;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
namespace NdaLesson04Lab.Controllers
{
    public class NdaAccountController : Controller
    {
        private readonly List<NdaAccount> NdaAccount = new ()
        {
            new NdaAccount
            {
                Id = 1,
                Name = "Nguyễn Văn An",
                Email = "an.nguyen@example.com",
                Phone = "0901234567",
                Avatar = "/images/avatar1.png",
                Address = "123 Đường Lê Lợi, Quận 1, TP. Hồ Chí Minh",
                Bio = "Lập trình viên C# yêu thích công nghệ.",
                Gender = 1, // 1: Nam
                Birthday = new DateTime(1995, 5, 20)
            },
            new NdaAccount
            {
                Id = 2,
                Name = "Trần Thị Mai",
                Email = "mai.tran@example.com",
                Phone = "0912345678",
                Avatar = "/images/av2.png",
                Address = "456 Đường Trần Hưng Đạo, Quận Hoàn Kiếm, Hà Nội",
                Bio = "Chuyên viên thiết kế UI/UX.",
                Gender = 0, // 0: Nữ
                Birthday = new DateTime(1998, 10, 12)
            },
            new NdaAccount
            {
                Id = 3,
                Name = "Lê Hoàng Nam",
                Email = "nam.le@example.com",
                Phone = "0923456789",
                Avatar = "/images/av3.png",
                Address = "789 Đường Nguyễn Văn Linh, Quận Hải Châu, Đà Nẵng",
                Bio = "Quản lý dự án phần mềm.",
                Gender = 1,
                Birthday = new DateTime(1990, 3, 15)
            },
            new NdaAccount
            {
                Id = 4,
                Name = "Phạm Thu Hương",
                Email = "huong.pham@example.com",
                Phone = "0934567890",
                Avatar = "/images/av4.png",
                Address = "101 Đường Nguyễn Huệ, TP. Quy Nhơn, Bình Định",
                Bio = "Thích du lịch và chụp ảnh.",
                Gender = 0,
                Birthday = new DateTime(2001, 7, 25)
            },
            new NdaAccount
            {
                Id = 5,
                Name = "Đặng Minh Trí",
                Email = "tri.dang@example.com",
                Phone = "0945678901",
                Avatar = "/images/av5.png",
                Address = "202 Đường 3 Tháng 2, Quận Ninh Kiều, Cần Thơ",
                Bio = "Chuyên gia phân tích dữ liệu.",
                Gender = 1,
                Birthday = new DateTime(1993, 12, 5)
            }
        };
        
        public IActionResult NdaIndex()
        {
            ViewBag.NdaAccount = NdaAccount;
            return View();
        }
        [Route("Ho-so-cua-toi",Name ="NdaProfile")]
        public IActionResult NdaProfile(int? id)
        {
            NdaAccount ndaAccount = new NdaAccount
            {
                Id = 1,
                Name = "Nguyễn Văn An",
                Email = "an.nguyen@example.com",
                Phone = "0901234567",
                Avatar = "/images/avatar1.png",
                Address = "123 Đường Lê Lợi, Quận 1, TP. Hồ Chí Minh",
                Bio = "Lập trình viên C# yêu thích công nghệ.",
                Gender = 1, // 1: Nam
                Birthday = new DateTime(1995, 5, 20)
            };
            if (id != null)
            {
                ndaAccount = NdaAccount.FirstOrDefault(x => x.Id == id);
            }

            ViewBag.NdaAccount = ndaAccount;
            return View();
        }
    }
}
