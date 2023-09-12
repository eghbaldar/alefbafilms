using System.ComponentModel.DataAnnotations;

namespace alefbafilm6.Application.Services.Newsletter.Commands.PostNewsletter
{
    public class RequestNewsletterServiceDto
    {
        [Required(ErrorMessage = "ایمیل اجباری است")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل قابل قبول نمی باشد")]
        public string Email { get; set; }
    }
}
