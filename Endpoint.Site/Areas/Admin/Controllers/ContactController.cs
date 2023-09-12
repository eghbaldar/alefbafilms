using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Contact.Commands.DeleteContact;
using alefbafilm6.Application.Services.Contact.Commands.UpdateContact;
using alefbafilms.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(RoleConsts.Admin)]
    public class ContactController : Controller
    {
        private readonly IContactFacade _contactFacade;
        public ContactController(IContactFacade contactFacade)
        {
            _contactFacade = contactFacade;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_contactFacade.GetContactService.Execute());
        }
        [HttpPost]
        public IActionResult Index(RequestUpdateContactServiceDto req)
        {
            return Json(_contactFacade.UpdateContactService.Execute(req));
        }
        [HttpPost]
        public IActionResult Delete(RequestDeleteContactServiceDto req)
        {
            return Json(_contactFacade.DeleteContactService.Execute(req));
        }
    }
}
