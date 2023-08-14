using alefbafilms.Common.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Staff.Commands.DeleteStaff
{
    public interface IDeleteStaffService
    {
        ResultDto Execute(RequestDeleteStaffDto req);
    }

}
