using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace alefbafilm6.Application.Services.Productions.Commands.PostProduct
{
    public class RequestPostProductServiceDto
    {
        [Required(ErrorMessage = "عنوان اثر اجباری است")]
        public string Title { get; set; }
        [Required(ErrorMessage = "توضیحات اثر اجباری است")]
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string Genre { get; set; }
        [Required(ErrorMessage = "زمان اثر الزامی است")]
        public string Time { get; set; }
        [Required(ErrorMessage = "تاریخ تولید اثر الزامی است")]
        public DateTime ProductionDate { get; set; }
        [Required(ErrorMessage = "عکس بزرگ الزامی است")]
        public IFormFile PhotoBig { get; set; }
        [Required(ErrorMessage = "عکس کوچک الزامی است")]
        public IFormFile PhotoSmall { get; set; }
    }
}
