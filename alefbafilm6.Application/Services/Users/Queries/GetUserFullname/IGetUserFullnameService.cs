using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Users.Queries.GetUserFullname
{
    public interface IGetUserFullnameService
    {
        ResultGetUserFullnameService Execute(RequestGetUserFullnameServiceDto req);
    }
}
