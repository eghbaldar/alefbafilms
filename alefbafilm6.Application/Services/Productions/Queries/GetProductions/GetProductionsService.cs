using alefbafilms.application.Interfaces.Contexts;
using AutoMapper;
using System.Globalization;

namespace alefbafilm6.Application.Services.Productions.Queries.GetProductions
{
    public class GetProductionsService : IGetProductionsService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper _mapper;
        public GetProductionsService(IDataBaseContext context,IMapper mapper)
        {
            _context = context;
            _mapper= mapper;
        }
        public ResultGetProductionsServiceDto Execute()
        {
            var productions = _context.Products
                 .OrderByDescending(o => o.InsertTime)
                 .Select(p => _mapper.Map<GetProductionsServiceDto>(p));

            return new ResultGetProductionsServiceDto
            {
                resultGetProductionsServiceDto = productions.ToList(),
            };
        }
    }
}
