using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        
        public string Index()
        {
            return "Welcome to ASP.NET MVC";
        }

       
        public string About()
        {
            return "Tên sinh viên: Nguyễn Hoàng Phúc";
        }

     
        public string Contact()
        {
            return "Email: hoangphucnguyen234@gmail.com";
        }
    }
}
