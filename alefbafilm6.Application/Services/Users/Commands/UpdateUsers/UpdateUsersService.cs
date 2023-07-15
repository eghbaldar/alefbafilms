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
            var user = _context.Users.Find(req.IdUser);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "User Not Found - کاربر پیدا نشد"
                };
            }
            else
            {
                user.fullname= req.Fullname;
                user.email= req.Email;
                user.password= req.Password;
                user.UpdateTime = DateTime.Now;

                _context.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "User has just changed - تغییرات کاربر اعمال شد",
                };
            }
        }
    }
}
