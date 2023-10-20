using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Productions.Commands.DeleteProduct
{
    public interface IDeleteProductService
    {
        ResultDto Execute(RequestDeleteProductServiceDto req);
    }
}
