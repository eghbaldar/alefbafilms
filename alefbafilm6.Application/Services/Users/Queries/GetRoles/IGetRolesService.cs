using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.application.Services.Users.Queries.GetRoles
{
    public interface IGetRolesService
    {
        List<ResultGetRolesDto> Execute();
    }
}
