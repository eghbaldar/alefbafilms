using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;
using alefbafilms.domian.Entities.Users;
using Bugeto_Store.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.application.Services.Users.Queries.AuthUsers.SignIn
{
    public class ResultAuthSignInUserDto
    {
        public long IdUser { get; set; }
        public string Fullname { get; set; }
        public List<string> Roles { get; set; }
    }
    public class RequestAuthSignInUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public interface IAuthSignInUser
    {
        ResultDto<ResultAuthSignInUserDto> Execute(RequestAuthSignInUserDto req);
    }
    public class AuthSignInUserService : IAuthSignInUser
    {
        private readonly IDataBaseContext _context;
        public AuthSignInUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultAuthSignInUserDto> Execute(RequestAuthSignInUserDto req)
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
                    Message = "کاربری با این مشخصات وجود ندارد - There is no use with this information.",
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
                    Message = "پسورد وارد شده نادرست است - Entered Password is not Correct",
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
                    Fullname=user.fullname,
                    IdUser=user.id,
                    Roles=roles,
                },
                IsSuccess = true,
                Message = " با موفقیت ورود کرده اید - You Entered Successfully",
            };
        }
    }
}
