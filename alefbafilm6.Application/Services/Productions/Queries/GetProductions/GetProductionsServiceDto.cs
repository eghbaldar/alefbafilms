using ServiceStack;
using System.ComponentModel.DataAnnotations;

namespace alefbafilm6.Application.Services.Productions.Queries.GetProductions
{
    public class GetProductionsServiceDto
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "عنوان اثر الزامی است")]
        public string Title { get; set; }
        [Required(ErrorMessage = "توضیحات اثر الزامی است")]
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string Category { get; set; }
        public string Genre { get; set; }
        public string GenreName { get; set; }
        [Required(ErrorMessage = "زمان اثر الزامی است")]
        public string Time { get; set; }
        [Required(ErrorMessage = "تاریخ تولید اثر الزامی است")]
        public string ProductionDate { get; set; }
        public string ProductionDate_Persian { get; set; }
        public string PhotoBig { get; set; }
        public string PhotoSmall { get; set; }
        public string InsertTime{ get; set; }
    }
}
