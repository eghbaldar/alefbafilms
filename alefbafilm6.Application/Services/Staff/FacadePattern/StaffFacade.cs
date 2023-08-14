using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Staff.Commands.DeleteStaff;
using alefbafilm6.Application.Services.Staff.Commands.PostStaff;
using alefbafilm6.Application.Services.Staff.Commands.UpdateStaff;
using alefbafilm6.Application.Services.Staff.Queries.GetStaff;
using alefbafilms.application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Staff.FacadePattern
{
    public class StaffFacade : IStaffFacade
    {
        ///////////////////////////////////////////////// Context
        private readonly IDataBaseContext _context;
        public StaffFacade(IDataBaseContext context)
        {
            _context = context;
        }
        ///////////////////////////////////////////////// PostStaffService
        private PostStaffService _postStaffService;
        public PostStaffService PostStaffService
        {
            get { return _postStaffService = _postStaffService ?? new PostStaffService(_context); }
        }
        ///////////////////////////////////////////////// GetStaffService
        private GetStaffService _getStaffService;
        public GetStaffService GetStaffService
        {
            get { return _getStaffService = _getStaffService ?? new GetStaffService(_context); }
        }
        ///////////////////////////////////////////////// DeleteStaffService
        private DeleteStaffService _deleteStaffService;
        public DeleteStaffService DeleteStaffService
        {
            get { return _deleteStaffService = _deleteStaffService ?? new DeleteStaffService(_context); }
        }
        ///////////////////////////////////////////////// UpdateStaffService
        private UpdateStaffService _updateStaffService;
        public UpdateStaffService UpdateStaffService
        {
            get { return _updateStaffService = _updateStaffService ?? new UpdateStaffService(_context); }
        }
    }
}

