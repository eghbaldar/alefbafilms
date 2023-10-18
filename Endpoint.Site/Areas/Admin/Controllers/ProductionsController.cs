using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Productions.Commands.PostProduct;
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
        private readonly IProductionFacade _productionFacade;
        public ProductionsController(IProductionFacade productionFacade)
        {
            _productionFacade = productionFacade;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
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
        [HttpPost]
        public IActionResult Create(RequestPostProductServiceDto req)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            IFormFile BigPhoto = req.PhotoBig;
            IFormFile SmallPhoto = req.PhotoSmall;
            return Json(_productionFacade.PostProductService.Execute(new RequestPostProductServiceDto
            {
                Title = req.Title,
                Description = req.Description,
                CategoryName = req.CategoryName,
                Genre = req.Genre,
                ProductionDate = req.ProductionDate,
                Time = req.Time,
                PhotoBig = BigPhoto,
                PhotoSmall= SmallPhoto
            })) ;
        }
    }
}
