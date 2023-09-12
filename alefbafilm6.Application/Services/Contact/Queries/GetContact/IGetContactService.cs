using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Contact.Queries.GetContact
{
    public interface IGetContactService
    {
        ResultGetContactServiceDto Execute(RequestGetContactServiceDto req);
    }
}
