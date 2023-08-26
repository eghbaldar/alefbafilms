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
        public IViewComponentResult Invoke()
        {
            //-------------------------------------------- GET USER's NAME by Cooke after loging
            // There two kinds of codes!
            // [1]
            //     var req = (User.Identity as ClaimsIdentity).Claims.FirstOrDefault();
            //     string reqValue = req.Value;
            //
            // [2]
            string reqValue = ClaimUtility.GetUserId(User as ClaimsPrincipal).Value.ToString();
            return View("Index", _userFacade.GetUserFullnameService.Execute(new RequestGetUserFullnameServiceDto
            {
                IdUser = long.Parse(reqValue),
            }));
        }
    }
}
