using System.ComponentModel.DataAnnotations;

namespace alefbafilm6.Application.Services.Gallery.Queries.GetGalleryCategory
{
    public class GetGalleryCategoryDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="نام دسته اجباری است")]
        [MinLength(3,ErrorMessage ="حداقل باید دارای 3 حرف باشد")]
        public string Name { get; set; }
    }
}
