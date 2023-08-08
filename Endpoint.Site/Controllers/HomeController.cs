using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Gallery.Queries.Common;
using Endpoint.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Endpoint.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGalleryFacade _galleryFacade;
        public HomeController(IGalleryFacade galleryFacade)
        {
            _galleryFacade = galleryFacade;
        }
        public IActionResult Index()
        {            
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Production()
        {
            return View();
        }
        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult Staff()
        {
            return View();
        }
        public IActionResult CEO()
        {
            return View();
        }
        public IActionResult Cooperation()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Gallery()
        {
            var models = new GetGalleryPhotosForAdminPhotos
            {
                _resultGetGalleryCategoryDto = _galleryFacade.GetGalleryCategoryService.Execute(),
                _resultGetGalleryPhotosServiceDto = _galleryFacade.GetGalleryPhotosService.Execute(),
            };
            return View(models);
        }
    }
}