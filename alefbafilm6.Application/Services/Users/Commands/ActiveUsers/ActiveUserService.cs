using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilms.application.Services.Users.Commands.ActiveUsers
{
    public class ActiveUserService : IActiveUserService
    {
        private readonly IDataBaseContext _context;
        public ActiveUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestActiveUserDto req)
        {
            var user = _context.Users.Find(req.IdUser);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Not Found User - کاربر یافت نشد",
                };
            }
            else
            {
                user.IsActive = !user.IsActive;
                var UserEnglishStatus = user.IsActive == true ? "Active" : "Inactive";
                var UserPersianStatus = user.IsActive == true ? "فعال" : "غیرفعال";

                _context.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = String.Format("User Activity Status was Changed to {0} - وضعیت کاربر {1} شد", UserEnglishStatus, UserPersianStatus),
                };
            }
        }
    }
}
