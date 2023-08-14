using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Contact.Commands.PostContact
{
    public interface IPostContactService
    {
        ResultDto Execute(RequestPostContactDto req);
    }
}
