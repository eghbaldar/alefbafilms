using alefbafilm6.Application.Services.Staff.Commands.DeleteStaff;
using alefbafilm6.Application.Services.Staff.Commands.PostStaff;
using alefbafilm6.Application.Services.Staff.Commands.UpdateStaff;
using alefbafilm6.Application.Services.Staff.Queries.GetStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Interfaces.FacadePattern
{
    public interface IStaffFacade
    {
        PostStaffService PostStaffService { get; }
        GetStaffService GetStaffService { get; }
        DeleteStaffService DeleteStaffService { get; }
        UpdateStaffService UpdateStaffService { get; }
    }
}
