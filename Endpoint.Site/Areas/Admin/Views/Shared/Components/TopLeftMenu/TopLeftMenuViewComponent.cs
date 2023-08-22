using alefbafilm6.Application.Interfaces.FacadePattern;
using Microsoft.AspNetCore.Mvc;
using alefbafilm6.Application.Services.Users.Queries.GetUserFullname;
using Endpoint.site.Utilities;
using System.Security.Claims;

namespace Endpoint.Site.Areas.Admin.Views.Components.TopLeftMenu
{
    public class TopLeftMenuViewComponent : ViewComponent
    {
        private readonly IUserFacade _userFacade;
        public TopLeftMenuViewComponent(IUserFacade userFacade)
        {
            _userFacade = userFacade;
        }
        public IViewComponentResult Invoke(string UserFullName)
        {
            //var principal = new ClaimsPrincipal(User);
            var req = (User.Identity as ClaimsIdentity).Claims.FirstOrDefault();
            string reqValue = req.Value;

            return View("Index", _userFacade.GetUserFullnameService.Execute(new RequestGetUserFullnameServiceDto
            {
                IdUser = long.Parse(reqValue),
            }));
        }
    }
}
