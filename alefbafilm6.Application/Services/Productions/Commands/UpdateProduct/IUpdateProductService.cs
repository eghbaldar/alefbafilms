using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public interface IUpdateProductService
    {
        ResultDto Execute(RequestUpdateProductServiceDto req);
    }
    public class UpdateProductService: IUpdateProductService
    {
        private readonly IDataBaseContext _context;
        public UpdateProductService(IDataBaseContext context)
        {
            _context=context;
        }
        public ResultDto Execute(RequestUpdateProductServiceDto req)
        {
            var product = _context.Products.Where(p=>p.Id==req.Id).FirstOrDefault();
            product.Title=req.Title;
            product.Description=req.Description;
            product.CategoryName=req.CategoryName;
            product.Genre=req.Genre;
            product.Time=req.Time;
            product.ProductionDate=req.ProductionDate;
            product.UpdateTime=DateTime.Now;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "اثر با موفقیت ویرایش شد",
            };
        }
    }
}
