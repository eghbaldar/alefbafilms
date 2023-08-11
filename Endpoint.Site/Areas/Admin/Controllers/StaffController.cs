using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Staff.Commands.PostStaff;
using alefbafilms.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(RoleConsts.Admin)]
    public class StaffController : Controller
    {
        private readonly IStaffFacade _staffFacade;
        public StaffController(IStaffFacade staffFacade)
        {
            _staffFacade= staffFacade;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(RequestPostStaffServiceDto req)
        {
            IFormFile formFile = Request.Form.Files[0];
            return Json(_staffFacade.PostStaffService.Execute(new RequestPostStaffServiceDto
            {
                Name = req.Name,
                Detail= req.Detail,
                Title= req.Title,
                File= formFile,
            }));
        }
    }
}
