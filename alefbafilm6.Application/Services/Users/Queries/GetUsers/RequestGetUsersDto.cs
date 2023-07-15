namespace alefbafilms.application.Services.Users.Queries.GetUsers
{
    /// STEP ........................................ 5
    /// <summary>
    /// we use DTO for getting values because of clean coding 
    /// </summary>
    public class RequestGetUsersDto
    {
        public string KeySearch { get; set; }
        public int Page { get; set; }
    }

}
