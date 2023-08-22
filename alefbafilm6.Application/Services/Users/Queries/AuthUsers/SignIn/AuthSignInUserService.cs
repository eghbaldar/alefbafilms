using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;
using Bugeto_Store.Common;
using Microsoft.EntityFrameworkCore;

namespace alefbafilms.application.Services.Users.Queries.AuthUsers.SignIn
{
    public class AuthSignInUserService : IAuthSignInUser
    {
        private readonly IDataBaseContext _context;
        public AuthSignInUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultAuthSignInUserDto> Execute(RequestAuthSignInUserDto req)
        {
            try
            {
                var user = _context.Users
    .Include(x => x.UserInRole)
    .ThenInclude(x => x.Role)
    .Where(x => x.email.Equals(req.Email) && x.IsActive == true)
    .FirstOrDefault();

                if (user == null)
                {
                    return new ResultDto<ResultAuthSignInUserDto>
                    {
                        Data = new ResultAuthSignInUserDto
                        {

                        },
                        IsSuccess = false,
                        Message = "کاربری با این مشخصات وجود ندارد",
                    };
                }

                var PasswordHasher = new PasswordHasher();
                var HashedPass = PasswordHasher.VerifyPassword(user.password, req.Password);
                if (!HashedPass)
                {
                    return new ResultDto<ResultAuthSignInUserDto>
                    {
                        Data = new ResultAuthSignInUserDto
                        {

                        },
                        IsSuccess = false,
                        Message = "پسورد وارد شده نادرست است",
                    };
                }

                List<string> roles = new List<string>();
                foreach (var item in user.UserInRole)
                {
                    roles.Add(item.Role.name);
                }

                return new ResultDto<ResultAuthSignInUserDto>
                {
                    Data = new ResultAuthSignInUserDto
                    {
                        Fullname = user.fullname,
                        IdUser = user.id,
                        Roles = roles,
                    },
                    IsSuccess = true,
                    Message = " با موفقیت ورود کرده اید ",
                };
            } catch(Exception ex)
            {
                return new ResultDto<ResultAuthSignInUserDto>
                {
                    Data = new ResultAuthSignInUserDto
                    {

                    },
                    IsSuccess = false,
                    Message = "خطایی رخ داده است"
                };
            }
        }
    }
}
