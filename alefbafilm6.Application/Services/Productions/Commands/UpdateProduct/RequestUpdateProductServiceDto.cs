using System.ComponentModel.DataAnnotations;

namespace alefbafilm6.Application.Services.Productions.Commands.UpdateProduct
{
    public class RequestUpdateProductServiceDto
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "عنوان اثر الزامی است")]
        public string Title { get; set; }
        [Required(ErrorMessage = "توضیحات اثر الزامی است")]
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string Genre { get; set; }
        [Required(ErrorMessage = "زمان اثر الزامی است")]
        public string? Time { get; set; }
        [Required(ErrorMessage = "تاریخ تولید اثر الزامی است")]
        [DataType(DataType.Date, ErrorMessage = "11")]
        public DateTime ProductionDate { get; set; }
    }
}
