using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.application.Services.Users.Commands.PostUsers
{
    public interface IPostUserService
    {
        ResultDto<ResultPostUserDto> Execute(RequestPostUserDto req);
    }
}
