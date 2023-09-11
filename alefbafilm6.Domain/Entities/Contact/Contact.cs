using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Domain.Entities.Contact
{
    public class Contact
    {
        public long Id { get; set; }
        [Required(ErrorMessage ="نام و نام خانوادگی خود را وارد کنید")]
        [StringLength(100, ErrorMessage = "تعداد کارکترها نباید بیش از 100 کارکتر باشد")]
        [MinLength(8,ErrorMessage ="تعداد کارکترها باید بیش از 8 کارکتر باشد")]
        public string FullName { get; set;}
        public string? Organization { get; set; } 
        [Required(ErrorMessage = "پست الکترونیکی خود را وارد کنید")]
        [EmailAddress(ErrorMessage ="فرمت آدرس ایمیل استاندارد نمی باشد")]
        public string Email { get; set;}
        [Required(ErrorMessage = "شماره همراه خود را وارد کنید")]
        [RegularExpression("09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}",ErrorMessage ="فرم شماره همراه استاندارد نمی باشد")]
        public string Phone { get; set;}
        [Required(ErrorMessage = "متن خود را وارد کنید")]
        [StringLength(500, ErrorMessage = "تعداد کارکترها نباید بیش از 500 کارکتر باشد")]
        [MinLength(20, ErrorMessage = "تعداد کارکترها باید بیش از 20 کارکتر باشد")]
        public string Message { get; set;}
        public bool IsCheck { get; set; }
    }
}
