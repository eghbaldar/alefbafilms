using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Productions.Commands.PostProduct;
using alefbafilm6.Application.Services.Productions.Queries.GetProductions;
using alefbafilms.application.Interfaces.Contexts;
using AutoMapper;

namespace alefbafilm6.Application.Services.Productions.FacadePattern
{
    public class ProductionFacade:IProductionFacade
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper _mapper;
        public ProductionFacade(IDataBaseContext context,IMapper mapper)
        {
            _context= context;
            _mapper= mapper;
        }
        ////////////////////// Post Productions
        private PostProductService _postProductService;
        public PostProductService PostProductService
        {
            get { return _postProductService = _postProductService ?? new PostProductService(_context); }
        }
        ////////////////////// Get Productions
        private GetProductionsService _getProductionsService;
        public GetProductionsService GetProductionsService
        {
            get { return _getProductionsService = _getProductionsService ?? new GetProductionsService(_context, _mapper); }
        }
    }
}
