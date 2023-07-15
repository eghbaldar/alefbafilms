namespace alefbafilms.application.Services.Users.Commands.UpdateUsers
{
    public class RequestUpdateUserDto {
        public long IdUser { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
