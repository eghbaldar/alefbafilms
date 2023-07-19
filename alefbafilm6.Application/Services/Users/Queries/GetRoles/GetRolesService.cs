using alefbafilms.application.Interfaces.Contexts;

namespace alefbafilms.application.Services.Users.Queries.GetRoles
{
    public class GetRolesService : IGetRolesService
    {
        private readonly IDataBaseContext _context;
        public GetRolesService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<ResultGetRolesDto> Execute()
        {
            var _roles = _context.Roles.Select(x => new ResultGetRolesDto
            {
                Id = x.id,
                Name = x.name,
            }).ToList();
            return _roles;
        }
    }
}
