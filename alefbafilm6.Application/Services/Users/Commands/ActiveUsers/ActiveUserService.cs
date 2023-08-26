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
            try
            {
                var user = _context.Users.Find(req.IdUser);
                if (user == null)
                {
                    return new ResultDto
                    {
                        IsSuccess = false,
                        Message = "کاربر یافت نشد",
                    };
                }
                else
                {
                    user.IsActive = !user.IsActive;
                    //var UserEnglishStatus = user.IsActive == true ? "Active" : "Inactive";
                    var UserPersianStatus = user.IsActive == true ? "فعال" : "غیرفعال";

                    _context.SaveChanges();

                    return new ResultDto
                    {
                        IsSuccess = true,
                        Message = String.Format("وضعیت کاربر {0} شد", UserPersianStatus),
                    };
                }
            } catch (Exception ex)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "خطایی رخ داده است"
                };
            }
        }
    }
}
