using alefbafilm6.Application.Services.Staff.Commands.PostStaff;
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
    }
}
