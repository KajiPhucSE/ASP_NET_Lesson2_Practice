using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            
            ViewBag.Name = "Nguyễn Hoàng Phúc";

            
            ViewData["Age"] = 20;

            
            string major = "CNTT";

            
            return View((object)major);
        }
    }
}
