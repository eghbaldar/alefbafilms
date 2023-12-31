﻿using alefbafilm6.Application.Services.Productions.Commands.DeleteProduct;
using alefbafilm6.Application.Services.Productions.Commands.PostProduct;
using alefbafilm6.Application.Services.Productions.Commands.UpdateProduct;
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
        UpdateProductService UpdateProductService { get; }
        DeleteProductService DeleteProductService { get; }
    }
}
