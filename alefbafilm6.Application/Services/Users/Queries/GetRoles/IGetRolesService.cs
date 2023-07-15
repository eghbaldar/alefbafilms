using alefbafilms.application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.application.Services.Users.Queries.GetRoles
{
    public class ResultGetRolesDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
    public interface IGetRolesService
    {
        List<ResultGetRolesDto> Execute();
    }
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
