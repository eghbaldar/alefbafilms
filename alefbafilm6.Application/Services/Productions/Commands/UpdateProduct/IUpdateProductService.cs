﻿using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Productions.Commands.UpdateProduct
{
    public interface IUpdateProductService
    {
        ResultDto Execute(RequestUpdateProductServiceDto req);
    }
}
