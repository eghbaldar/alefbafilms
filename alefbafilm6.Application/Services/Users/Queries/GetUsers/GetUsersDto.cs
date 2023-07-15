namespace alefbafilms.application.Services.Users.Queries.GetUsers
{
    /// STEP ........................................ 2
    /// <summary>
    /// Just back the files that I want to show them via DTO method
    /// </summary>
    public class GetUsersDto
    {
        public long id { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool IsActive { get; set; }
    }

}
