namespace alefbafilms.application.Services.Users.Commands.PostUsers
{
    public class RequestPostUserDto
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<RequestPostRoleOfUserDto> Roles { get; set; }
    }
}
