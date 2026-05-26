using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        
        public IActionResult Detail(int? id)
        {
            
            if (!id.HasValue)
            {
                return Content("Lỗi: Vui lòng cung cấp mã sản phẩm (Ví dụ: /Product/Detail/5).");
            }

            return Content("Product ID = " + id.Value);
        }

        
        public IActionResult Category(string name)
        {
           
            if (string.IsNullOrEmpty(name))
            {
                return Content("Lỗi: Vui lòng cung cấp tên danh mục (Ví dụ: /Product/Category?name=Laptop).");
            }

            return Content("Category = " + name);
        }
    }
}
