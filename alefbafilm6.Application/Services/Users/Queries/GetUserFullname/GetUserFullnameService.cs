using alefbafilms.application.Interfaces.Contexts;

namespace alefbafilm6.Application.Services.Users.Queries.GetUserFullname
{
    public class GetUserFullnameService: IGetUserFullnameService
    {
        private readonly IDataBaseContext _context;
        public GetUserFullnameService(IDataBaseContext context)
        {
            _context= context;
        }
        public ResultGetUserFullnameService Execute(RequestGetUserFullnameServiceDto req)
        {
            var user = _context.Users.Find(req.IdUser);
            if (user == null)
            {
                return new ResultGetUserFullnameService
                {
                    Fullname = "نامشخص"
                };
            }
            else
            {
                return new ResultGetUserFullnameService
                {
                    Fullname = user.fullname
                };
            }
        }
    }
}
