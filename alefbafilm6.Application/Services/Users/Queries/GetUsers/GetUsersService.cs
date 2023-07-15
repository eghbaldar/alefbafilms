using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common;

namespace alefbafilms.application.Services.Users.Queries.GetUsers
{
    /// STEP ........................................ 3
    /// <summary>
    /// A class for implementing the interface (IGetUsers)
    /// In this class we will need to connect to Database, so we have to injection of DataBaseContext
    /// </summary>
    public class GetUsersService : IGetUsersService
    {
        // INJECTION
        private readonly IDataBaseContext _context;
        public GetUsersService(IDataBaseContext context)
        {
            _context = context;
        }
        // End INJECTION
        public ResultGetUsersDto Execute(RequestGetUsersDto request)
        {
            var users = _context.Users.AsQueryable(); //said ready for new query and I will luanch you later on!
            if (!String.IsNullOrEmpty(request.KeySearch))
            {
                users = users.Where(p => p.fullname.Contains(request.KeySearch) || p.email.Contains(request.KeySearch));
            }

            // With Pagination
            int RowsCount;
            var userlist = users.ToPaged(request.Page, 20, out RowsCount).Select(p => new GetUsersDto
            {
                id = p.id,
                fullname = p.fullname,
                email = p.email,
                password=p.password,
                IsActive= p.IsActive,
            }).ToList();

            // Without Pagination
            //////////return users.select(p => new getusersdto
            //////////{
            //////////    id = p.id,
            //////////    fullname = p.fullname,
            //////////    email = p.email,            
            //////////}).tolist();

            return new ResultGetUsersDto
            {
                Rows = RowsCount,
                Users = userlist,
            };
        }
    }

}
