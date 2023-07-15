using alefbafilms.application.Services.Users.Commands.ActiveUsers;
using alefbafilms.application.Services.Users.Commands.DeleteUsers;
using alefbafilms.application.Services.Users.Commands.PostUsers;
using alefbafilms.application.Services.Users.Commands.UpdateUsers;
using alefbafilms.application.Services.Users.Queries.GetRoles;
using alefbafilms.application.Services.Users.Queries.GetUsers;
using alefbafilms.Common.Constants;
using Endpoint.site.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Endpoint.site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(RoleConsts.Admin)]
    public class UsersController : Controller
    {
        // Injection of IGetUserService to this Controller
        private readonly IGetUsersService _getUsersService;
        private readonly IGetRolesService _getRolesService;
        private readonly IPostUserService _postUserService;
        private readonly IDeleteUsersService _deleteUsersService;
        private readonly IActiveUserService _activeUserService;
        private readonly IUpdateUsersService _updateUsersService;
        public UsersController(
            IGetUsersService getUsersService,
            IGetRolesService getRolesService,
            IPostUserService postUserService,
            IDeleteUsersService deleteUsersService,
            IActiveUserService activeUserService,
            IUpdateUsersService updateUsersService)
        {
            _getUsersService = getUsersService;
            _getRolesService = getRolesService;
            _postUserService = postUserService;
            _deleteUsersService = deleteUsersService;
            _activeUserService = activeUserService;
            _updateUsersService = updateUsersService;
        }
        // End of Injection

        [HttpGet]
        public IActionResult Index(String SearchKey, int page=1)
        {
            return View(_getUsersService.Execute(new RequestGetUsersDto
            {
                KeySearch = SearchKey,
                Page = page,
            })) ;
        }

        [HttpPost]
        public IActionResult Index(long IdUser)
        {
            return Json(_deleteUsersService.Execute(new RequestDeleteUserDto
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
            ViewBag.Roles = new SelectList(_getRolesService.Execute(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Fullname, string Email, string Password, long roleId)
        {
            var result = _postUserService.Execute(new RequestPostUserDto
            {
                Fullname = Fullname,
                Password = Password,
                Email = Email,
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
            return Json(_activeUserService.Execute(new RequestActiveUserDto
            {
                IdUser = IdUser
            }));
        }

        [HttpPost]
        public IActionResult UpdateUser(long IdUser, string Fullname, string Email, string Password)
        {
            return Json(_updateUsersService.Execute(new RequestUpdateUserDto
            {
                IdUser = IdUser,
                Fullname = Fullname,
                Email = Email,
                Password = Password
            }));
        }
    }
}
