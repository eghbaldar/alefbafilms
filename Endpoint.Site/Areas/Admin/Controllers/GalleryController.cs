using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Gallery.Commands.PostGalleryCategory;
using alefbafilms.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(RoleConsts.Admin)]
    public class GalleryController : Controller
    {
        private readonly IGalleryFacade _galleryFacade;
        public GalleryController(IGalleryFacade galleryFacade)
        {
            _galleryFacade = galleryFacade;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_galleryFacade.GetGalleryCategoryService.Execute());
        }

        [HttpPost]
        public IActionResult PostCategory(string Name)
        {
            return Json(_galleryFacade.PostGalleryCategoryService.Execute(new RequestPostGalleryCategoryDto
            {
                Name = Name,
            }));
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            return Json(_galleryFacade.DeleteGalleryCategoryService.Execute(Id));
        }
        [HttpPost]
        public IActionResult Update(int Id,string Name)
        {
            return Json(_galleryFacade.UpdateGalleryCategoryService.Exectue(Id, Name));
        }
    }
}
