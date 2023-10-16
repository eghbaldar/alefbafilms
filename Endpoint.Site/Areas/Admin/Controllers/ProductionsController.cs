using alefbafilms.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Endpoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(RoleConsts.Admin)]
    public class ProductionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            var Category = new[]
            {
            new { Id = 1, Name = "فیلم کوتاه" },
            new { Id = 2, Name = "فیلم بلند" },
            new { Id = 3, Name = "تبلیغاتی" },
            new { Id = 4, Name = "جُنگ" }
            }.ToList();

            var Genre = new[]
{
            new { Id = 2, Name = "موزیک ویدیو" },
            new { Id = 3, Name = "انیمیشن" },
            new { Id = 4, Name = "مستند" },
            new { Id = 5, Name = "داستانی" },
            new { Id = 6, Name = "تجربی" }
            }.ToList();

            ViewBag.Category = new SelectList(Category, "Id", "Name");
            ViewBag.Genre = new SelectList(Genre, "Id", "Name");
            return View();
        }
    }
}
