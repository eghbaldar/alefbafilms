using Microsoft.AspNetCore.Http;

namespace alefbafilm6.Application.Services.Staff.Commands.PostStaff
{
    public class RequestPostStaffServiceDto
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public IFormFile File { get; set; }
    }    

}
