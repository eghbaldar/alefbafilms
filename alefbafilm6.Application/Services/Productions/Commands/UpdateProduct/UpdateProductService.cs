using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Productions.Commands.UpdateProduct
{
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
