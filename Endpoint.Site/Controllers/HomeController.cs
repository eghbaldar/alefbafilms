using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Contact.Commands.PostContact;
using alefbafilm6.Application.Services.Gallery.Queries.Common;
using alefbafilm6.Application.Services.Newsletter.Commands.PostNewsletter;
using Endpoint.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Endpoint.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGalleryFacade _galleryFacade;
        private readonly IStaffFacade _staffFacade;
        private readonly IPagesFacade _pagesFacade;
        private readonly IContactFacade _contactFacade;
        private readonly INewsletterFacade _newsletterFacade;
        public HomeController(
            IGalleryFacade galleryFacade,
            IStaffFacade staffFacade,
            IPagesFacade pagesFacade,
            IContactFacade contactFacade,
            INewsletterFacade newsletterfacade)
        {
            _galleryFacade = galleryFacade;
            _staffFacade = staffFacade;
            _pagesFacade = pagesFacade;
            _contactFacade = contactFacade;
            _newsletterFacade = newsletterfacade;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View(_pagesFacade.GetAboutPageService.Execute());
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(RequestPostContactDto req)
        {
            return Json(_contactFacade.PostContactService.Execute(new RequestPostContactDto
            {
                FullName = req.FullName,
                Organization = req.Organization,
                Email = req.Email,
                Message = req.Message,
                Phone = req.Phone,
            }));
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
            return View(_staffFacade.GetStaffService.Execute());
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
        [HttpPost]
        public IActionResult Newsletter(RequestNewsletterServiceDto req)
        {
            return Json(_newsletterFacade.PostNewsletterService.Execute(req));
        }
    }
}