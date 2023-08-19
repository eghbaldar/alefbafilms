using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilms.application.Services.Users.Commands.UpdateUsers
{
    public class UpdateUsersService : IUpdateUsersService
    {
        private readonly IDataBaseContext _context;
        public UpdateUsersService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestUpdateUserDto req)
        {
            try
            {
                var user = _context.Users.Find(req.IdUser);
                if (user == null)
                {
                    return new ResultDto
                    {
                        IsSuccess = false,
                        Message = "کاربر پیدا نشد"
                    };
                }
                else
                {
                    user.fullname = req.Fullname;
                    user.email = req.Email;
                    user.password = req.Password;
                    user.UpdateTime = DateTime.Now;

                    _context.SaveChanges();

                    return new ResultDto
                    {
                        IsSuccess = true,
                        Message = "تغییرات کاربر اعمال شد",
                    };
                }
            }
            catch (Exception ex)
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
