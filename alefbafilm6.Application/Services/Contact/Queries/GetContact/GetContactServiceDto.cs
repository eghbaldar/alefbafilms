namespace alefbafilm6.Application.Services.Contact.Queries.GetContact
{
    public class GetContactServiceDto
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Organization { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public bool IsCheck { get; set; }
    }
}
