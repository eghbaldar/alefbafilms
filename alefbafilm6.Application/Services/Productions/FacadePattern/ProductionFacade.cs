using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Productions.Commands.PostProduct;
using alefbafilms.application.Interfaces.Contexts;

namespace alefbafilm6.Application.Services.Productions.FacadePattern
{
    public class ProductionFacade:IProductionFacade
    {
        private readonly IDataBaseContext _context;
        public ProductionFacade(IDataBaseContext context)
        {
            _context= context;
        }

        private PostProductService _postProductService;
        public PostProductService PostProductService
        {
            get { return _postProductService = _postProductService ?? new PostProductService(_context); }
        }
    }
}
