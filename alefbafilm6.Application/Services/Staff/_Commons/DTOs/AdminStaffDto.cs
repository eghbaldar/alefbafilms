using alefbafilm6.Application.Services.Staff.Commands.UpdateStaff;
using alefbafilm6.Application.Services.Staff.Queries.GetStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Staff._Commons.DTOs
{
    public class AdminStaffDto
    {
        public RequestUpdateStaffServiceDto RequestUpdateStaffServiceDto { get; set; }
        public List<GetStaffServiceDto> GetStaffServiceDto { get; set; }
        public GetStaffServiceDto StaffValidation { get; set; }
    }
}
