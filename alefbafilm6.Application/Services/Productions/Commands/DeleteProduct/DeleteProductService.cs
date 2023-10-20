using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Productions.Commands.DeleteProduct
{
    public class DeleteProductService: IDeleteProductService
    {
        private readonly IDataBaseContext _context;
        public DeleteProductService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestDeleteProductServiceDto req)
        {
            var product = _context.Products.Where(p=>p.Id==req.Id).FirstOrDefault();
            product.DeleteTime=DateTime.Now;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "اثر مورد نظر پاک شد"
            };
        }
    }
}
