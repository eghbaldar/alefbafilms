using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilms.application.Services.Users.Commands.ActiveUsers;
using alefbafilms.application.Services.Users.Commands.DeleteUsers;
using alefbafilms.application.Services.Users.Commands.PostUsers;
using alefbafilms.application.Services.Users.Commands.UpdateUsers;
using alefbafilms.application.Services.Users.Queries.GetRoles;
using alefbafilms.application.Services.Users.Queries.GetUsers;
using alefbafilms.Common.Constants;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using alefbafilms.domian.Entities.Users;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using FluentValidation.Results;
using NuGet.Protocol;

namespace Endpoint.site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(RoleConsts.Admin)]
    public class UsersController : Controller
    {
        // Injection of [IUserFacade] & [IValidator] to this Controller
        private readonly IUserFacade _userFacade;
        private readonly IValidator<RequestPostUserDto> _validator;
        public UsersController(IUserFacade userFacade, IValidator<RequestPostUserDto> validator)
        {
            _userFacade = userFacade;
            _validator = validator;
        }
        // End of Injection

        [HttpGet]
        public IActionResult Index(String SearchKey, int page=1)
        {
            return View(_userFacade.GetUsersService.Execute(new RequestGetUsersDto
            {
                KeySearch = SearchKey,
                Page = page,
            }));
        }

        [HttpPost]
        public IActionResult Index(long IdUser)
        {
            return Json(_userFacade.DeleteUserService.Execute(new RequestDeleteUserDto
            {
                IdUser = IdUser
            }));
        }

        [HttpGet] // What does it matter to define this method?
                  // 1) Becasue we will have two (or more) IActionResult with the same name [index] 
                  // 2) and why [httpGet]? why not [httpPost]? Because the below action is going to be GET information, not POST
        public IActionResult Create()
        {
            //ViewBag.Roles = _getRolesService.Execute(); //Accoring to this code you have to create your own selector-control for example with <a></a> or stuff like that!
            ViewBag.Roles = new SelectList(_userFacade.GetRolesService.Execute(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(RequestPostUserDto req, long roleId)
        {

            //// Validation
            //var valResult = _validator.Validate(req);
            //if (!valResult.IsValid)
            //{
            //    return View(req);
            //    //return BadRequest(valResult.Errors);
            //    ///////////////////////////////////////
            //    //var errorGroups = valResult.Errors.GroupBy(x=>x.PropertyName).ToList();
            //    //var errors = errorGroups.Select(x => new
            //    //{
            //    //    PropertyName = x.Key,
            //    //    Error=x.Select(x=>x.ErrorMessage).ToArray()
            //    //});
            //    //return BadRequest(errors);
            //}

            // Insert Process
            var result = _userFacade.PostUserService.Execute(new RequestPostUserDto
            {
                Fullname = req.Fullname,
                Password = req.Password,
                Email = req.Email,
                Roles = new List<RequestPostRoleOfUserDto>()
                {
                    // why the below code? because we will get only one role in every register.
                    // if we change our registor form in order to get more than one role, then we have to change the below code, dude!
                    new RequestPostRoleOfUserDto
                    {
                        Id=roleId,
                    }
                }
            }); ;
            return Json(result);
        }

        [HttpPost]
        public IActionResult ActiveUser(long IdUser)
        {
            return Json(_userFacade.ActiveUserService.Execute(new RequestActiveUserDto
            {
                IdUser = IdUser
            }));
        }

        [HttpPost]
        public IActionResult UpdateUser(long IdUser, string Fullname, string Email, string Password)
        {
            return Json(_userFacade.UpdateUsersService.Execute(new RequestUpdateUserDto
            {
                IdUser = IdUser,
                Fullname = Fullname,
                Email = Email,
                Password = Password
            }));
        }
    }
}
