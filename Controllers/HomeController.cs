using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        // Hiển thị "Welcome to ASP.NET MVC"
        public string Index()
        {
            return "Welcome to ASP.NET MVC";
        }

        // Hiển thị tên sinh viên
        public string About()
        {
            return "Tên sinh viên: Nguyễn Hoàng Phúc";
        }

        // Hiển thị email sinh viên
        public string Contact()
        {
            return "Email: hoangphucnguyen234@gmail.com";
        }
    }
}