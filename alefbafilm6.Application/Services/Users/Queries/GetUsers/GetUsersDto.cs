using System.ComponentModel.DataAnnotations;

namespace alefbafilms.application.Services.Users.Queries.GetUsers
{
    /// STEP ........................................ 2
    /// <summary>
    /// Just back the files that I want to show them via DTO method
    /// </summary>
    public class GetUsersDto
    {
        public long id { get; set; }
        [Required(ErrorMessage = "نام و نام خانوادگی اجباری است")]
        [MinLength(10, ErrorMessage = "تعداد کارکتر باید بیش از 10 کارکتر باشد")]
        public string fullname { get; set; }
        [Required(ErrorMessage = "ایمیل اجباری است")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل قابل قبول نمی باشد")]
        public string email { get; set; }
        [Required(ErrorMessage = "کلمه عبور اجباری است")]
        [MinLength(5, ErrorMessage = "تعداد کارکتر باید بیش از 5 کارکتر باشد")]
        [MaxLength(20, ErrorMessage = "تعداد کارکتر باید کمتر از 20 کارکتر باشد")]
        public string password { get; set; }
        public bool IsActive { get; set; }
    }

}
