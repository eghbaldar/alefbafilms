using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;
using alefbafilms.domian.Entities.Users;
using Bugeto_Store.Common;

namespace alefbafilms.application.Services.Users.Commands.PostUsers
{
    public class PostUserService : IPostUserService
    {
        private readonly IDataBaseContext _context;
        public PostUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultPostUserDto> Execute(RequestPostUserDto req)
        {
            var PassHasher = new PasswordHasher();
            var HashedPass = PassHasher.HashPassword(req.Password);

            User user = new User()
            {
                fullname = req.Fullname,
                email= req.Email,                
                password = HashedPass,
            };
            List<UserInRole> UserInRole = new List<UserInRole>();
            foreach (var item in req.Roles)
            {
                var role = _context.Roles.Find(item.Id);
                UserInRole.Add(new UserInRole
                {
                    Role = role,
                    RoleId=role.id,
                    User = user,   
                    UserId=user.id, // This ID has ***already*** reserved!
                });
            }
            // [****] user.UserInRole = UserInRole;
            _context.Users.Add(user); // Exective Line!
            _context.UserInRoles.AddRange(UserInRole); // Instead of using this code you could use [****] line

            _context.SaveChanges();

            return new ResultDto<ResultPostUserDto>()
            {
                Data = new ResultPostUserDto
                {
                    Id = user.id, // This ID is a real ID and not reserved ID anymore!
                },
                IsSuccess = true,
                Message = "New User Has Just Been Added!",
            };
        }
    }
}
