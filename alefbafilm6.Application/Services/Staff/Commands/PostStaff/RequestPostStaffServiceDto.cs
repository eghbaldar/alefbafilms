using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace alefbafilm6.Application.Services.Staff.Commands.PostStaff
{
    public class RequestPostStaffServiceDto
    {
        [Required(ErrorMessage = "نام کامل کارمند اجباری است")]
        [MinLength(8, ErrorMessage = "نام کامل کارمند حداقل 8 کارکتر باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "سمت کارمند اجباری است")]
        [MinLength(5, ErrorMessage = "سمت  کارمند حداقل 5 کارکتر باشد")]
        public string Title { get; set; }
        [Required(ErrorMessage = "توضیحات اجباری است")]
        [MinLength(8, ErrorMessage = "توضیحات حداقل 10 کارکتر باشد")]
        public string Detail { get; set; }
        [Required(ErrorMessage = "فایل اجباری است")]
        public IFormFile File { get; set; }
    }    

}
