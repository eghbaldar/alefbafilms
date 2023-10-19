using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Productions.Commands.PostProduct;
using alefbafilm6.Application.Services.Productions.Commands.UpdateProduct;
using alefbafilm6.Common.Constants;
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
            ProductionsConstants productionsConstants = new ProductionsConstants();
            List<SelectListItem> listCat = productionsConstants.Category().Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.Name,
            }).ToList();
            List<SelectListItem> listGenre = productionsConstants.Genre().Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.Name,
            }).ToList();

            ViewBag.Category = listCat;
            ViewBag.Genre = listGenre;
            return View(_productionFacade.GetProductionsService.Execute());
        }
        [HttpGet]
        public IActionResult Create()
        {

            ProductionsConstants productionsConstants = new ProductionsConstants();
            List<SelectListItem> listCat = productionsConstants.Category().Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text= u.Name,                
            }).ToList();            
            List<SelectListItem> listGenre = productionsConstants.Genre().Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text= u.Name,                
            }).ToList();

            ViewBag.Category = listCat;
            ViewBag.Genre = listGenre;
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
                PhotoSmall = SmallPhoto
            }));
        }
        [HttpPost]
        public IActionResult Update(RequestUpdateProductServiceDto req)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Json(_productionFacade.UpdateProductService.Execute(req));
        }
    }
}
