using alefbafilms.Common.Dtos;
using alefbafilms.domian.Entities.Users;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.application.Services.Users.Queries.AuthUsers.SignIn
{
    public interface IAuthSignInUser
    {
        ResultDto<ResultAuthSignInUserDto> Execute(RequestAuthSignInUserDto req);
    }
}
