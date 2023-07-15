using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.application.Services.Users.Queries.GetUsers
{
    /// STEP ........................................ 1
    /// <summary>
    /// Return a list of USERs
    /// </summary>
    public interface IGetUsersService
    {
        ResultGetUsersDto Execute(RequestGetUsersDto request);
    }

}
