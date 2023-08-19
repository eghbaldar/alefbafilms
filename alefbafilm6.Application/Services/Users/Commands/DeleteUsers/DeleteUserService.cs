using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilms.application.Services.Users.Commands.DeleteUsers
{
    public class DeleteUserService : IDeleteUsersService
    {
        private readonly IDataBaseContext _context;
        public DeleteUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestDeleteUserDto req)
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
                    user.DeleteTime = DateTime.Now;
                    _context.SaveChanges();
                    return new ResultDto
                    {
                        IsSuccess = true,
                        Message = "کاربر با موفقیت حذف شد"
                    };
                }
            }catch (Exception ex)
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
