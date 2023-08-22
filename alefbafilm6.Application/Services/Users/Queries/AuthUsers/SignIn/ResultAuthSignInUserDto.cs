namespace alefbafilms.application.Services.Users.Queries.AuthUsers.SignIn
{
    public class ResultAuthSignInUserDto
    {
        public long IdUser { get; set; }
        public string Fullname { get; set; }
        public List<string> Roles { get; set; }
    }
}
