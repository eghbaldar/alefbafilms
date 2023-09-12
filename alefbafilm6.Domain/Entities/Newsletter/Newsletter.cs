using alefbafilms.domian.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Domain.Entities.Newsletter
{
    public class Newsletter:BaseEntity
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "ایمیل اجباری است")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل قابل قبول نمی باشد")]
        public string Email { get; set; }
    }
}
