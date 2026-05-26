using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            // Truyền dữ liệu bằng ViewBag (Động)
            ViewBag.Name = "Nguyễn Hoàng Phúc";

            // Truyền dữ liệu bằng ViewData (Dạng Dictionary)
            ViewData["Age"] = 20;

            // Truyền dữ liệu bằng Model (Khuyên dùng vì an toàn và chặt chẽ nhất)
            string major = "CNTT";

            // Ép kiểu (object) để hệ thống hiểu đây là Model data, không phải tên của View
            return View((object)major);
        }
    }
}