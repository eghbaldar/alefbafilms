using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Users.Queries.GetUserFullname;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.application.Services.Users.Commands.ActiveUsers;
using alefbafilms.application.Services.Users.Commands.DeleteUsers;
using alefbafilms.application.Services.Users.Commands.PostUsers;
using alefbafilms.application.Services.Users.Commands.UpdateUsers;
using alefbafilms.application.Services.Users.Queries.AuthUsers.SignIn;
using alefbafilms.application.Services.Users.Queries.GetRoles;
using alefbafilms.application.Services.Users.Queries.GetUsers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Users.FacadePattern
{
    public class UserFacade : IUserFacade
    {
        /// <summary>
        /////////////////////////////////////////// CONTEXT
        /// </summary>
        private readonly IDataBaseContext _context;
        public UserFacade(IDataBaseContext context)
        {
            _context = context;
        }
        /// <summary>
        /// /////////////////////////////////////// Introduce of GetUsersService
        /// </summary>
        private GetUsersService _getUsersService;
        public GetUsersService GetUsersService
        {
            get {
                return _getUsersService = _getUsersService ?? new GetUsersService(_context);
            }
        }
        /// <summary>
        /// /////////////////////////////////////// Introduce of GetRolesService
        /// </summary>
        private GetRolesService _getRolesService;
        public GetRolesService GetRolesService
        {
            get
            {
                return _getRolesService = _getRolesService ?? new GetRolesService(_context);
            }
        }
        /// <summary>
        /// /////////////////////////////////////// Introduce of PostUserService
        /// </summary>
        private PostUserService _postUserService;
        public PostUserService PostUserService
        {
            get
            {
                return _postUserService = _postUserService ?? new PostUserService(_context);
            }
        }
        /// <summary>
        /// /////////////////////////////////////// Introduce of DeleteUserService
        /// </summary>
        private DeleteUserService _deleteUserService;
        public DeleteUserService DeleteUserService
        {
            get
            {
                return _deleteUserService=_deleteUserService ?? new DeleteUserService(_context);
            }
        }
        /// <summary>
        /// /////////////////////////////////////// Introduce of ActiveUserService
        /// </summary>
        private ActiveUserService _activeUserService;
        public ActiveUserService ActiveUserService
        {
            get
            {
               return  _activeUserService =_activeUserService ?? new ActiveUserService(_context);
            }
        }
        /// <summary>
        /// /////////////////////////////////////// Introduce of UpdateUsersService
        /// </summary>
        private UpdateUsersService _updateUsersService;
        public UpdateUsersService UpdateUsersService
        {
            get
            {
                return _updateUsersService=_updateUsersService ?? new UpdateUsersService(_context);
            }
        }
        /// <summary>
        /// /////////////////////////////////////// Introduce of AuthSignInUserService
        /// </summary>
        private AuthSignInUserService _authSignInUserService;
        public AuthSignInUserService AuthSignInUserService
        {
            get
            {
                return _authSignInUserService = _authSignInUserService?? new AuthSignInUserService(_context);
            }
        }
        /// <summary>
        /// /////////////////////////////////////// Get User Fullname by Id
        /// </summary>
        private GetUserFullnameService _getUserFullnameService;
        public GetUserFullnameService GetUserFullnameService
        {
            get { return _getUserFullnameService = _getUserFullnameService ?? new GetUserFullnameService(_context); }
        }
    }
}
