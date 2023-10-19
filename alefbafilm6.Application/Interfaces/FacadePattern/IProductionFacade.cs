using alefbafilm6.Application.Services.Productions.Commands.PostProduct;
using alefbafilm6.Application.Services.Productions.FacadePattern;
using alefbafilm6.Application.Services.Productions.Queries.GetProductions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Interfaces.FacadePattern
{
    public interface IProductionFacade
    {
        PostProductService PostProductService { get; }
        GetProductionsService GetProductionsService { get; }
    }
}
