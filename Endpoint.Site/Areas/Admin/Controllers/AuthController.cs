using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilms.application.Services.Users.Queries.AuthUsers.SignIn;
using Endpoint.site.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Endpoint.site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly IUserFacade _userFacade;
        public AuthController(IUserFacade userFacade)
        {
            _userFacade = userFacade;
        }

        [HttpGet]
        public IActionResult Index(string ReturnUrl = "/")
        {
            if(User.Identity.IsAuthenticated) return RedirectToAction("Index", "Users", new { Areas = "admin" });            
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(string Email, string Password, string url = "/")
        {
            var signIn = _userFacade.AuthSignInUserService.Execute(new RequestAuthSignInUserDto
            {
                Email = Email,
                Password = Password
            });
            if (signIn.IsSuccess)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,signIn.Data.IdUser.ToString()),
                    new Claim(ClaimTypes.Email,Email),
                    new Claim(ClaimTypes.Name,signIn.Data.Fullname),
                };

                foreach (var item in signIn.Data.Roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, item));
                }

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var propertise = new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.Now.AddYears(1),
                };
                HttpContext.SignInAsync(principal, propertise);

                /**************************
                User.Identity.Name  => Access User's Name in all of website!
                and about other things, please check out the Root > Utilities > ClaimUtility.cs
                ***************************/
            }
            return Json(signIn);
        }
        
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home", new { area = ""});
        }
    }
}
