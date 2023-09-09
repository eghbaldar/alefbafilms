using alefbafilms.domian.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Domain.Entities.Gallery
{
    public class Gallery: BaseEntity
    {
        public long Id { get; set; }
        [Required(ErrorMessage ="عنوان تصویر اجباری است")]
        [MinLength(3,ErrorMessage ="عنوان تصویر حداقل باید 3 کارکتر باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "توضیحات تصویر اجباری است")]
        [MinLength(10, ErrorMessage = "توضیحات تصویر حداقل باید 10 کارکتر باشد")]
        public string Detail { get; set; }
        [Required(ErrorMessage = "انتخاب تصویر اجباری است")]
        public string Filename { get; set; }
        public ICollection<GalleryInCategory> GalleryCategory { get; set; }
    }
}
