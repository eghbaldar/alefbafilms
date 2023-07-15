namespace alefbafilms.application.Services.Users.Queries.GetUsers
{
    /// STEP ........................................ 4
    /// <summary>
    /// Get list of users plus an extra parameter
    /// </summary>
    public class ResultGetUsersDto
    {
        public List<GetUsersDto> Users { get; set; }
        public int Rows { get; set; }
    }

}
