using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Gallery;
using alefbafilm6.Application.Services.Gallery.Commands.DeleteGalleryPhotos;
using alefbafilm6.Application.Services.Gallery.Commands.PostGallery;
using alefbafilm6.Application.Services.Gallery.Commands.PostGalleryCategory;
using alefbafilm6.Application.Services.Gallery.Queries.Common;
using alefbafilm6.Application.Services.Gallery.Queries.GetGalleryCategory;
using alefbafilm6.Application.Services.Gallery.Queries.GetGalleryPhotos;
using alefbafilm6.Domain.Entities.Gallery;
using alefbafilms.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Json(_galleryFacade.PostGalleryCategoryService.Execute(new RequestPostGalleryCategoryDto
                {
                    Name = Name,
                }));
            }
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            return Json(_galleryFacade.DeleteGalleryCategoryService.Execute(Id));
        }
        [HttpPost]
        public IActionResult Update(int Id, string Name)
        {
            return Json(_galleryFacade.UpdateGalleryCategoryService.Exectue(Id, Name));
        }
        [HttpGet]
        public IActionResult create()
        {
            ViewBag.Item = new SelectList(
                _galleryFacade.GetGalleryCategoryService.Execute().GalleryCategory.ToList()
                , "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult create(string Name, string Detail, int IdGalleryCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                IFormFile file = Request.Form.Files[0];
                RequestPostGalleryServiceDto req = new RequestPostGalleryServiceDto
                {
                    Name = Name,
                    Detail = Detail,
                    Filename = file,
                    IdGalleryCategory = IdGalleryCategory,
                };
                return Json(_galleryFacade.PostGalleryService.Execute(req));
            }
        }
        [HttpGet]
        public IActionResult photos()
        {
            var models = new GetGalleryPhotosForAdminPhotos
            {
                _resultGetGalleryCategoryDto = _galleryFacade.GetGalleryCategoryService.Execute(),
                _resultGetGalleryPhotosServiceDto = _galleryFacade.GetGalleryPhotosService.Execute(),
            };
            return View(models);
        }
        [HttpPost]
        public IActionResult Delete(long Id)
        {
            return Json(_galleryFacade.DeleteGalleryPhotoService.Execute(
                new RequestDeleteGalleryPhotoServiceDto
                {
                    Id = Id
                }
                ));
        }
    }
}
