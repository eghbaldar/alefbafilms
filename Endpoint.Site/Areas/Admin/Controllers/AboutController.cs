using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Pages.Commands.PostAboutPage;
using alefbafilms.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(RoleConsts.Admin)]
    public class AboutController : Controller
    {
        private readonly IPagesFacade _pagesFacade;
        public AboutController(IPagesFacade pagesFacade)
        {
            _pagesFacade = pagesFacade;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_pagesFacade.GetAboutPageService.Execute());
        }
        [HttpPost]
        public IActionResult Update(string AboutPage)
        {
            return Json(_pagesFacade.UpdateAboutPageService.Execute(new RequestUpdateAboutPageDto
            {
                AboutPage = AboutPage,
            }));
        }
    }
}
