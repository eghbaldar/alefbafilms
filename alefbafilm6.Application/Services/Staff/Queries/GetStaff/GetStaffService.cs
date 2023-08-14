using alefbafilms.application.Interfaces.Contexts;

namespace alefbafilm6.Application.Services.Staff.Queries.GetStaff
{
    public class GetStaffService : IGetStaffService
    {
        private readonly IDataBaseContext _context;
        public GetStaffService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetStaffServiceDto Execute()
        {
            var staff = _context.Staff.Select(x => new GetStaffServiceDto
            {
                Id = x.Id,
                Name = x.Name,
                Title = x.Title,
                Detail = x.Detail,
                File = x.File,
            }).ToList();
            return new ResultGetStaffServiceDto
            {
                _resultGetStaffServiceDto = staff,
            };
        }
    }
}
