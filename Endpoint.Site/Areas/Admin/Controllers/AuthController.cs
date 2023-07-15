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
        private readonly IAuthSignInUser _authSignInUser;
        public AuthController(IAuthSignInUser authSignInUser)
        {
            _authSignInUser = authSignInUser;
        }

        [HttpGet]
        public IActionResult Index(string ReturnUrl = "/")
        {
            ViewBag.url = ReturnUrl;
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(string Email, string Password, string url = "/")
        {
            var signIn = _authSignInUser.Execute(new RequestAuthSignInUserDto
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
            }
            return Json(signIn);
        }
        
        public IActionResult SignOut()
        {//info@eghbaldar.ir

            //HttpContext.SignOutAsync();
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Json("");
            //return RedirectToAction("Index", "Home");

            //HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //return RedirectToAction("Index","Users");

            //if (ClaimUtility.DoesUserExist(HttpContext.User))
            //    return Json(ClaimUtility.DoesUserExist(HttpContext.User));
            //else
            //    return Json(ClaimUtility.DoesUserExist(HttpContext.User));

            //if ((HttpContext.User != null) && HttpContext.User.Identity.IsAuthenticated)
            //    return Json("true");
            //else
            //    return Json("false");
        }
    }
}
