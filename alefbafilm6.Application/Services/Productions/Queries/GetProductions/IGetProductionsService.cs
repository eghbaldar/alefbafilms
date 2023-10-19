using alefbafilm6.Domain.Entities.Productions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Productions.Queries.GetProductions
{
    public interface IGetProductionsService
    {
        ResultGetProductionsServiceDto Execute();
    }
}
