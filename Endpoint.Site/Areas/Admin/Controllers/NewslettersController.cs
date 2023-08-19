using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Newsletter.Commands.DeleteNewsletter;
using alefbafilm6.Application.Services.Newsletter.FacadePattern;
using alefbafilms.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(RoleConsts.Admin)]
    public class NewslettersController : Controller
    {
        private readonly INewsletterFacade _newsletterFacade;
        public NewslettersController(INewsletterFacade newsletterFacade)
        {
            _newsletterFacade = newsletterFacade;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_newsletterFacade.GetNewsletterService.Execute());
        }
        [HttpPost]
        public IActionResult Delete(RequestDeleteNewsletterServiceDto req)
        {
            return Json(_newsletterFacade.DeleteNewsletterService.Execute(req));
        }
    }
}
