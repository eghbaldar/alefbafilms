using alefbafilm6.Application.Services.Contact.Commands.PostContact;
using alefbafilm6.Application.Services.Contact.Commands.UpdateContact;
using alefbafilm6.Application.Services.Contact.Queries.GetContact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Interfaces.FacadePattern
{
    public interface IContactFacade
    {
        PostContactService PostContactService { get; }
        GetContactService GetContactService { get; }
        UpdateContactService UpdateContactService { get; }
    }
}
