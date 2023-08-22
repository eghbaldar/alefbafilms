using alefbafilm6.Application.Services.Users.Queries.GetUserFullname;
using alefbafilms.application.Services.Users.Commands.ActiveUsers;
using alefbafilms.application.Services.Users.Commands.DeleteUsers;
using alefbafilms.application.Services.Users.Commands.PostUsers;
using alefbafilms.application.Services.Users.Commands.UpdateUsers;
using alefbafilms.application.Services.Users.Queries.AuthUsers.SignIn;
using alefbafilms.application.Services.Users.Queries.GetRoles;
using alefbafilms.application.Services.Users.Queries.GetUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Interfaces.FacadePattern
{
    public interface IUserFacade
    {
        GetUsersService GetUsersService { get; }
        GetRolesService GetRolesService { get; }
        PostUserService PostUserService { get; }
        DeleteUserService DeleteUserService { get; }
        ActiveUserService ActiveUserService { get; }
        UpdateUsersService UpdateUsersService { get; }
        AuthSignInUserService AuthSignInUserService { get; }
        GetUserFullnameService GetUserFullnameService { get; }
    }
}
