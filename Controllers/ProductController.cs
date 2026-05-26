using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        // 1. Action Detail: Nhận tham số id từ URL
        // Cấu trúc URL mặc định sẽ hiểu số ở cuối là id: /Product/Detail/5
        public IActionResult Detail(int? id)
        {
            // Xử lý nâng cao: Kiểm tra nếu không có id
            if (!id.HasValue)
            {
                return Content("Lỗi: Vui lòng cung cấp mã sản phẩm (Ví dụ: /Product/Detail/5).");
            }

            return Content("Product ID = " + id.Value);
        }

        // 2. Action Category: Nhận tham số name từ Query String
        // Query String là phần nằm sau dấu chấm hỏi (?): /Product/Category?name=Laptop
        public IActionResult Category(string name)
        {
            // Xử lý nâng cao: Kiểm tra nếu name bị trống
            if (string.IsNullOrEmpty(name))
            {
                return Content("Lỗi: Vui lòng cung cấp tên danh mục (Ví dụ: /Product/Category?name=Laptop).");
            }

            return Content("Category = " + name);
        }
    }
}