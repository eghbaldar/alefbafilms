using alefbafilms.domian.Commons;
using System.ComponentModel.DataAnnotations;

namespace alefbafilms.domian.Entities.Users
{
    //User Entity  
    public class User : BaseEntity
    {
        //The below property won't be used, because this class will inherit from [BaseEntity] that there is own Id there.
        public long id { get; set; }

        [Required(ErrorMessage ="نام و نام خانوادگی اجباری است")]
        [MinLength(10, ErrorMessage = "تعداد کارکتر باید بیش از 10 کارکتر باشد")]
        public string fullname { get; set; }

        [Required(ErrorMessage = "ایمیل اجباری است")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل قابل قبول نمی باشد")]
        public string email { get; set; }

        [Required(ErrorMessage ="کلمه عبور اجباری است")]
        [MinLength(5,ErrorMessage ="تعداد کارکتر باید بیش از 5 کارکتر باشد")]
        [MaxLength(20,ErrorMessage = "تعداد کارکتر باید کمتر از 20 کارکتر باشد")]
        public string password { get; set; }

        public bool IsActive { get; set; } = true;
        public virtual ICollection<UserInRole>? UserInRole { get; set; }
    }
}
