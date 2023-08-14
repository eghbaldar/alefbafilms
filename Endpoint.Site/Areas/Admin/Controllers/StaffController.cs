using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Staff.Commands.DeleteStaff;
using alefbafilm6.Application.Services.Staff.Commands.PostStaff;
using alefbafilm6.Application.Services.Staff.Commands.UpdateStaff;
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
            return View(_staffFacade.GetStaffService.Execute());
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
        [HttpPost]
        public IActionResult Delete(RequestDeleteStaffDto req)
        {
            return Json(_staffFacade.DeleteStaffService.Execute(req));
        }
        [HttpPost]
        public IActionResult Update(RequestUpdateStaffServiceDto req)
        {
            var image = Request.Form.Files[0];
            return Json(_staffFacade.UpdateStaffService.Execute(new RequestUpdateStaffServiceDto
            {
                Name = req.Name,
                Detail = req.Detail,
                Title = req.Title,
                Id = req.Id,
                File = image,
            }));
        }
    }
}
